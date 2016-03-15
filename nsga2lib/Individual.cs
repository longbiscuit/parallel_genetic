using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsga2lib
{
    public class Individual : IComparable<Individual>, ICloneable
    {
        /// <summary>
        /// Chromosoma de un individuo. Cada elemento es un gen que representa el índice numérico en el array de los posibles valores de genes.
        /// </summary>
        public Chromosome Chromosome;

        /// <summary>
        /// Valor de la función de fitness sobre éste individuo
        /// </summary>
        public int FitnessValue;

        public Individual(int chromosomeSize)
        {
            Chromosome = new Chromosome(chromosomeSize);
        }

        public void InitRandomGenes(int genValuesCount)
        {
            for (int i = 0 ; i < Chromosome.Genes.Length; i++)
            {
                Chromosome.Genes[i] = RandomGenerator.Next(genValuesCount);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("Individuo\n");
            /*
            for (int i = 0; i < Chromosome.Genes.Length; i++)
            {
                sb.AppendFormat(" [{0}] = {1}\n", i, Chromosome.Genes[i]);
            }
             * */
            sb.AppendFormat("{0}", FitnessValue);
            
            return sb.ToString();
        }

        public int CompareTo(Individual comparee)
        {
            if ( this.FitnessValue > comparee.FitnessValue )
            {
                return 1;
            } else if ( this.FitnessValue < comparee.FitnessValue )
            {
                return -1;
            } else
            {
                return 0;
            }
        }



        #region ICloneable Members

        public object Clone()
        {
            Individual result = new Individual(this.Chromosome.Genes.Length);
            result.Chromosome.Genes = (int[])this.Chromosome.Genes.Clone();
            result.FitnessValue = this.FitnessValue;
            return (object) result;
        }

        #endregion
    }
}
