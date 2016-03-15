using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsga2lib
{
    public class Chromosome
    {
        public int[] Genes;
        public int GenesValuesCount;
        public Chromosome(int chromosomeSize)
        {
            Genes = new int[chromosomeSize];
        }
        public void Cross(Chromosome otherChromosome, int crossIndex)
        {
            //TODO: Optimizar la copia a buffer del trozo más pequeño
            int[] buffer = new int[crossIndex];
            //Guardamos el trozo del otro cromosoma
            Array.Copy(otherChromosome.Genes, buffer, crossIndex);
            //Escribimos en el trozo del otro cromosoma
            Array.Copy(Genes,otherChromosome.Genes,crossIndex);
            //Copiamos el trozo guardado en el cromosoma propio
            Array.Copy(buffer, Genes, crossIndex);
        }
        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            for ( int i = 0 ; i < Genes.Length ; i++ )
            {
                sb.AppendFormat("{0} ", Genes[i]);
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
