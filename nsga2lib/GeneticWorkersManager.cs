using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace nsga2lib
{
    public class GeneticWorkersManager
    {
        public int NumThreads = 2;
        public int PopulationSize;
        public int ParentsSize;
        public IProblemModel Model;
        public double MutationProbability;
        private GeneticWorker[] GeneticWorkers;
        private Thread[] GeneticWorkerThreads;
        private AutoResetEvent[] GeneticWorkerEvents;
        private bool Initialised = false;

        public void Init()
        {
            if ( this.Initialised ) return;
            //Dividimos los padres entre los threads
            int sizePopThread = Convert.ToInt32(ParentsSize/NumThreads);
            int sizePopThreadAll = Convert.ToInt32(PopulationSize/NumThreads);

            GeneticWorkerThreads = new Thread[NumThreads];
            GeneticWorkers = new GeneticWorker[NumThreads];
            GeneticWorkerEvents = new AutoResetEvent[NumThreads];

            for (int i = 0; i < NumThreads; i++)
            {
                GeneticWorkerEvents[i] = new AutoResetEvent(false);
                GeneticWorkers[i] = new GeneticWorker()
                                        {
                                            Model = this.Model,
                                            MutationProb = this.MutationProbability,
                                            StartIndex = sizePopThread*i,
                                            EndIndex = sizePopThread*(i + 1),
                                            StartIndexAll = sizePopThreadAll*i,
                                            EndIndexAll = sizePopThreadAll*(i + 1),
                                            FinishedEvent = GeneticWorkerEvents[i]
                                        };
            }
            //Añadimos al último la diferencia de la división
            GeneticWorkers[NumThreads - 1].EndIndex += ParentsSize%NumThreads;
            GeneticWorkers[NumThreads - 1].EndIndexAll += PopulationSize%NumThreads;

            Initialised = true;
        }
        public int StartMultiThreadJob(Population pop, GeneticWorker.GeneticJob job)
        {
            Init();
            //Especificamos la operación a realizar, la población y 
            for (int i = 0; i < NumThreads; i++)
            {
                GeneticWorkers[i].Job = job;
                GeneticWorkers[i].Population = pop;
                GeneticWorkerThreads[i] = new Thread(new ThreadStart(GeneticWorkers[i].Start));
                GeneticWorkerThreads[i].Start();
            }
            //Esperamos a que todos terminen
            WaitHandle.WaitAll(GeneticWorkerEvents);
            //Recolectamos las cuentas de operaciones realizadas
            int result = 0;
            for (int i = 0; i < NumThreads; i++)
            {
                result += GeneticWorkers[i].OperationsCount;
            }
            return result;
        }
    }
}
