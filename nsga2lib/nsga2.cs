using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nsga2lib
{
    public class nsga2
    {
        public int PopulationSize;
        public int NumCurrentGeneration = 0; //Current Generation nº
        public int MaxGeneration = 10000;
        public IProblemModel Model;
        public GeneticAlgorithm geneticAlgorithm;

        public void init() {
            geneticAlgorithm = new GeneticAlgorithm();
            //geneticAlgorithm.ChromosomeSize = 10;
            //geneticAlgorithm.GenValues = new ArrayList();
        }
        public void run() {
            Population[] P = new Population[MaxGeneration]; //Change to arraylist or similar
            Population[] R = new Population[MaxGeneration]; //Change to arraylist or similar
            Population[] Q = new Population[MaxGeneration]; //Change to arraylist or similar
            Population[] F = new Population[PopulationSize]; //Change to arraylist or similar
            int N = PopulationSize; //Alias

            //Initial Generation
            int t = NumCurrentGeneration = 0; //Alias
            P[0] = new Population(PopulationSize);
            P[0].RandomInitialize(PopulationSize,Model.ChromosomeSize,Model.GenValues.Count);
            P[0].NonDominatedSort();
            P[0].AssignFitnessNonDominationLevel();
            Q[0] = P[0].MakeChilds(PopulationSize);

            while ( ! StopCriteria() ) {
                
                //Main Loop

                R[t] = P[t].Union(Q[t]);
                F = R[t].FastNonDominatedSort();
                P[t + 1] = new Population(PopulationSize);
                int i = 1;
                while (P[t + 1].Members.Length + F[i].Members.Length <= N)
                {
                    F[i].CrowdingDistanceAssignment();
                    P[t+1] = P[t+1].Union(F[i]);
                    i++;
                }
                F[i].SortByCrowdedComparisonOperator();
                P[t+1] = P[t+1].Union(F[i].SubSet(1,N-P[t+1].Members.Length));
                Q[t+1] = P[t+1].MakeChilds(PopulationSize);
                NumCurrentGeneration = t = t+1;
            }
            
        }
        private bool StopCriteria()
        {
            return (NumCurrentGeneration < MaxGeneration);
        }
    }
}
