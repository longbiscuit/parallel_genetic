using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsga2lib
{

    public class Population
    {

        public Individual[] Members;

        public Population(int size)
        {
            Members = new Individual[size];
        }
        public void Sort()
        {
            Array.Sort(Members);
        }
        public void RandomSort()
        {
            //Optimización: Utilizamos un algoritmo de ordenación al azar non-biased
            //http://www.codinghorror.com/blog/archives/001015.html
            //Knuth-Fisher-Yates shuffle algorithm
            for (int i = Members.Length - 1; i > 0; i--)
            {
                int n = RandomGenerator.Next(i + 1);
                Swap(ref Members[i], ref Members[n]);
            }
        }
        private void Swap(ref Individual i1, ref Individual i2)
        {
            Individual temp = i1;
            i1 = i2;
            i2 = temp;
        }

        public int[] GetFitnessData()
        {
            int[] result = new int[Members.Length];
            for ( int i = 0 ; i < Members.Length ; i++ )
            {
                result[i] = Members[i].FitnessValue;
            }
            return result;
        }
        
        public void RandomInitialize(int PopulationSize, int ChromosomeSize, int GenValuesCount) {
            for (int i = 0; i < this.Members.Length; i++)
            {
                this.Members[i] = new Individual(ChromosomeSize);
                this.Members[i].InitRandomGenes(GenValuesCount);
            }
        }
        public void NonDominatedSort() {
        }
        public void AssignFitnessNonDominationLevel() {
        }
        public Population MakeChilds(int size) {
            return new Population(size);
        }

        public Population Union(Population pop) {
            Individual[] members1 = (Individual[]) this.Members.Clone();
            Individual[] members2 = (Individual[]) pop.Members.Clone();
            Individual[] newMembers = new Individual[pop.Members.Length + this.Members.Length];
           
            Array.Copy(members2, newMembers, members2.Length);
            Array.Copy(members1, 0, newMembers, members2.Length,
                       newMembers.Length - members2.Length);
  
             /*
            newMembers = members1;
            newMembers = (Individual[])newMembers.Concat(members2);
            **/
            Population result = new Population(newMembers.Length);
            result.Members = newMembers;

            return result;
        }

        public Population[] FastNonDominatedSort() {
            Population[] result = new Population[this.Members.Length];
            return result;
        }

        public void CrowdingDistanceAssignment() {
        }
        public Population SubSet(int start, int end) {
            return new Population(end-start);
        }
        public void SortByCrowdedComparisonOperator()
        {
        }

        public Population Subpopulation(int size)
        {
            Population result = new Population(size);
            for (int i = 0; i < size ; i++ )
            {
                result.Members[i] = (Individual)this.Members[i].Clone();
            }
            return result;
        }
    }

}
