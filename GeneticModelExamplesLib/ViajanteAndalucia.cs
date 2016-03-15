using System.Text;
using nsga2lib;
using System.Collections;

namespace GeneticModelExamplesLib
{
    public class ViajanteAndalucia : IProblemModel
    {
        public ArrayList GenValues { get; set; }
        public int ChromosomeSize { get; set; }
        public int Generation { get; set; }
        private readonly int[,] distancias;
        public ViajanteAndalucia() {
            ChromosomeSize = 8;
            GenValues = new ArrayList();
            GenValues.Add("Almería");
            GenValues.Add("Cádiz");
            GenValues.Add("Córdoba");
            GenValues.Add("Granada");
            GenValues.Add("Huelva");
            GenValues.Add("Jaen");
            GenValues.Add("Málaga");
            GenValues.Add("Sevilla");

            distancias = new int[,] {
                { 0,     615,	 364,	 166,	 608,	 283,	 210,	 503 },
                { 615,	 0,      268,	 347,	 248,	 360,	 268,	 145 },
                { 364,	 268,	 0,      200,	 236,	 105,	 172,	 133 },
                { 166,	 347,	 200,	 0,      373,	 91,	 164,	 269 },
                { 608,	 248,	 236,	 373,	 0,      335,	 318,	 96  },
                { 283,	 360,	 105,	 91,	 335,	 0,      236,	 234 },
                { 210,	 268,	 172,	 164,	 318,	 236,	 0,      215 },
                { 503,	 145,	 133,	 269,	 96,	 234,	 215,    0},	
            };

        }
        public int Fitness(int[] genes,int i)
        {
            ArrayList cities = new ArrayList();
            cities.Add(genes[0]);
            int distance = 0;

            for (int j = 1; j < genes.Length; j++)
            {
                if (cities.Contains(genes[j]))
                {
                    return 10000;
                }
                distance += distancias[genes[j - 1], genes[j]];
                cities.Add(genes[j]);
            }
            return distance;
        }
        public int FitnessDimension
        {
            get
            {
                return 1;
            }
        }
        public string Decode(int[] chromosome)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            foreach (int i in chromosome)
            {
                sb.AppendFormat("{0} ",GenValues[i]);
            }
            sb.Append("]");
            return sb.ToString();
        }
        public bool StoppingCriteria()
        {
            //if (Generation > 10) return true;
            return false;
        }
    }
}
