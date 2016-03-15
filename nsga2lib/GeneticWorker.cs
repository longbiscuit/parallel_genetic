using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace nsga2lib
{
    public class GeneticWorker
    {
        public enum GeneticJob { EvaluateAll, Evaluate, Cross, Mutate }

        public GeneticJob Job;

        public int StartIndex;
        public int EndIndex;
        public int StartIndexAll;
        public int EndIndexAll;
        public Population Population;
        public IProblemModel Model;
        public Double MutationProb;
        public int OperationsCount;
        public AutoResetEvent FinishedEvent;

        public void Start()
        {
            OperationsCount = 0;
            switch (this.Job)
            {
                case GeneticJob.EvaluateAll:
                    Evaluate(this.Population, Model, StartIndexAll, EndIndexAll);
                    break;
                case GeneticJob.Evaluate:
                    Evaluate(this.Population, Model, StartIndex, EndIndex);
                    break;
                case GeneticJob.Cross:
                    OperationsCount = CrossParents(this.Population, StartIndex, EndIndex);
                    break;
                case GeneticJob.Mutate:
                    OperationsCount = MutateParents(this.Population, MutationProb, StartIndex, EndIndex, Model.GenValues.Count);
                    break;
            }
            FinishedEvent.Set();

        }

        #region Evaluate
        public static void Evaluate(Population pop, IProblemModel model, int startIndex, int endIndex)
        {
            for ( int i = startIndex ; i < endIndex ; i++ )
            {
                pop.Members[i].FitnessValue = model.Fitness(pop.Members[i].Chromosome.Genes,1);
            }
        }
        #endregion

        #region Cross
        public static int CrossParents(Population parents, int startIndex, int endIndex)
        {
            //parents.RandomSort();
            for (int i = startIndex ; i < endIndex ; i = i + 2)
            {
                Cross(parents.Members[i], parents.Members[i + 1]);
                //Stats.AddCross();
            }
            return endIndex - startIndex+1;
        }
        /// <summary>
        /// Cross genes for two individual at random single point
        /// </summary>
        /// <param name="i1">First individual for crossing genes</param>
        /// <param name="i2">Second individual for crossing genes</param>
        /// <returns>Individual with genes crossed</returns>
        private static void Cross(Individual i1, Individual i2)
        {
            i1.Chromosome.Cross(i2.Chromosome, RandomGenerator.Next(i2.Chromosome.Genes.Count()));
        }
        #endregion

        #region Mutate

        public static int MutateParents(Population parents, double MutationProb, int startIndex, int endIndex, int GenesValuesCount)
        {
            int mutations = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                mutations += Mutate(parents.Members[i], MutationProb, GenesValuesCount);

            }
            return mutations;
        }
        //Optimización: No delegar el conocimiento de los valores de genes
        private static int Mutate(Individual indv, double MutationProb, int GenesValuesCount)
        {
            int mutations = 0;
            //Recorremos el individuo, mutando cuando la probabilidad lo indice
            //La posibilidad es para cada gen del chromosoma
            for ( int i = 0 ; i < indv.Chromosome.Genes.Count() ; i++)
            {
                if ( RandomGenerator.NextDouble() < MutationProb )
                {
                    Mutate(indv, i, GenesValuesCount);
                    mutations++;
                }
            }
            return mutations;
        }
        /// <summary>
        /// Mutate a random gen of an individual, chanching it to a new random gene value.
        /// </summary>
        /// <param name="indv">Individual with mutated gen</param>
        /// <param name="mutationIndex">Index of gen in genes to mutate</param>
        /// <returns></returns>
        private static void Mutate(Individual indv, int mutationIndex, int GenesValuesCount)
        {
            int newGenValue = RandomGenerator.Next(GenesValuesCount);
            while (indv.Chromosome.Genes[mutationIndex] == newGenValue)
            {
                newGenValue = RandomGenerator.Next(GenesValuesCount);
            }
            indv.Chromosome.Genes[mutationIndex] = newGenValue;
        }
        #endregion
    }
}
