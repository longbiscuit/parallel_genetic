using System;
using System.Threading;
using nsga2lib;

namespace nsga2lib
{
    public class GeneticAlgorithm
    {
        #region Properties that define the algorithm
        
        public int PopulationSize;
        public double MutationProbability;
        public double ParentsProportion;
        public int MaxGeneration = 100;
        public IProblemModel Model;
        public GeneticStats Stats;
        private int ParentsSize;
        public Population Population;

        public volatile bool Pause = false;
        public volatile bool MultiThread = false;
        public volatile int NumThreads;
        private GeneticWorkersManager GeneticWorkersManager;

        #region Propiedades para enlazar eventos de estadísticas y gráficas
        public volatile bool ActivateStatistics = false;
        public volatile bool ActivateGraphics = false;
        public delegate void DrawStatistics(GeneticStats stats);
        public delegate void DrawGraphics(Population population, bool firstInvocation);
        public delegate void FinishHandle();
        public DrawStatistics DrawStatisticsMethod;
        public DrawGraphics DrawGraphicsMethod;
        public FinishHandle FinishEvent;
        private bool PopulationGraphFirstDraw = true;
        #endregion

        private bool initialised = false;
        
        #endregion


        #region Initialisation

        private void Init()
        {
            if (initialised) return;

            if (PopulationSize == 0) throw new Exception("Population size not defined");
            if (MutationProbability == 0) throw new Exception("Mutation Probability not defined");
            if (ParentsProportion == 0) throw new Exception("Parents proportion not defined");
            if (Model == null) throw new Exception("Problem model not defined");


            SetUpParentsSize();

            if (this.MultiThread)
            {
                GeneticWorkersManager = new GeneticWorkersManager();
                GeneticWorkersManager.NumThreads = NumThreads;
                GeneticWorkersManager.PopulationSize = PopulationSize;
                GeneticWorkersManager.ParentsSize = ParentsSize;
                GeneticWorkersManager.Model = Model;
                GeneticWorkersManager.MutationProbability = MutationProbability;
            }

            Stats = new GeneticStats();

            initialised = true;
        }

        private void SetUpParentsSize()
        {
            int selectSize = Convert.ToInt32(PopulationSize * ParentsProportion);
            if (selectSize % 2 != 0)
            {
                if (selectSize < PopulationSize)
                {
                    selectSize++;
                }
                else if (selectSize > 0)
                {
                    selectSize--;
                }
                else
                {
                    throw new Exception("Could not asign even number of parent population");
                }
            }
            ParentsSize = selectSize;
        }


        #endregion


        public void Start()
        {
            Population parents;

            Init();
            Stats.Start();

            Stats.Generation = Model.Generation = 1;
            Population = new Population(PopulationSize);
            Population.RandomInitialize(PopulationSize, Model.ChromosomeSize, Model.GenValues.Count);
            EvaluateAll(Population);
            Sort(Population);

            
            while ( ! Model.StoppingCriteria() && Model.Generation < MaxGeneration )
            {
                HandleUIEvents();
                parents = SelectParents(Population);
                CrossParents(parents);
                MutateParents(parents);
                Evaluate(parents);
                Population = SelectBest(parents, Population);

                Stats.Generation = Model.Generation = Model.Generation + 1;
                
                while (Pause)
                {
                }
            }
            Stats.Stop();
            HandleStatsAndPopulationGraphFinish();
        }

        #region UI Event Handling

        private void HandleUIEvents()
        {
            Stats.BestIndividualChromosome = Population.Members[0].Chromosome;
            Stats.BestFitness = Population.Members[0].FitnessValue;
            HandleStatistics();
            HandlePopulationGraphMiddle();
        }
        private void HandleStatistics()
        {
            if (ActivateStatistics && DrawStatisticsMethod != null) 
            {
                DrawStatisticsMethod.Invoke(Stats);
            }
        }
        private void HandlePopulationGraphMiddle()
        {
            if (ActivateGraphics && DrawGraphicsMethod != null)
            {
                DrawGraphicsMethod.Invoke(Population, PopulationGraphFirstDraw);
                PopulationGraphFirstDraw = false;
            }
        }
        private void HandleStatsAndPopulationGraphFinish()
        {
            if (DrawStatisticsMethod != null)
            {
                DrawStatisticsMethod.Invoke(this.Stats);
            }
            if (DrawGraphicsMethod != null)
            {
                DrawGraphicsMethod.Invoke(Population, PopulationGraphFirstDraw);
                PopulationGraphFirstDraw = false;
            }
            if (FinishEvent != null )
            {
                FinishEvent.Invoke();
            }

        }
        #endregion

        #region Non parallel methods: Selection

        private Population SelectBest(Population parents, Population currentPopulation)
        {
            Population joint = parents.Union(currentPopulation);
            Sort(joint);
            return joint.Subpopulation(PopulationSize);
        }
        public Population SelectParents(Population pop)
        {

            //Population.Sort();
            Population result = pop.Subpopulation(ParentsSize);
            return result;
        }
        #endregion

        #region Parallel Methods: Evaluate, Sorting, RandomSorting, Mutation, Crossing

        private void Evaluate(Population pop)
        {
            if (!this.MultiThread)
            {
                GeneticWorker.Evaluate(pop, Model, 0, pop.Members.Length);
            }
            else
            {
                GeneticWorkersManager.StartMultiThreadJob(pop, GeneticWorker.GeneticJob.Evaluate);
            }
        }
        private void EvaluateAll(Population pop)
        {
            if (!this.MultiThread)
            {
                GeneticWorker.Evaluate(pop, Model, 0, pop.Members.Length);
            }
            else
            {
                GeneticWorkersManager.StartMultiThreadJob(pop, GeneticWorker.GeneticJob.EvaluateAll);
            }
        }
        private void Sort(Population pop)
        {
            //if (!this.MultiThread)
            //{
                pop.Sort();
            //}
            //else
            //{
            //    GeneticWorkersManager.StartMultiThreadJob(pop, GeneticWorker.GeneticJob.Sort);
            //}
            
        }
        private void RandomSort(Population pop)
        {
            //if (!this.MultiThread)
            //{
                pop.RandomSort();
            //} else
            //{
            //    GeneticWorkersManager.StartMultiThreadJob(pop, GeneticWorker.GeneticJob.RandomSort);
            //}
        }

        private void CrossParents(Population parents)
        {
            if (!this.MultiThread)
            {
                Stats.TotalCrosses += GeneticWorker.CrossParents(parents, 0, parents.Members.Length);
            } else
            {
                Stats.TotalCrosses += GeneticWorkersManager.StartMultiThreadJob(parents, GeneticWorker.GeneticJob.Cross);
            }
        }
        private void MutateParents(Population parents)
        {
            
            if (!this.MultiThread)
            {
                Stats.TotalMutations += GeneticWorker.MutateParents(parents, MutationProbability, 0, parents.Members.Length, Model.GenValues.Count);
            }
            else
            {
                Stats.TotalCrosses += GeneticWorkersManager.StartMultiThreadJob(parents, GeneticWorker.GeneticJob.Mutate);
            }
        }
        #endregion
    }
}
