using System;
using GeneticModelExamplesLib;
using nsga2lib;
using System.Collections;

namespace nsga2test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prueba algoritmo genético");
            //Inicializamos la factoria de individuos


            GeneticAlgorithm alg = new GeneticAlgorithm();
            alg.Model = new ViajanteAndalucia();
            alg.MutationProbability = 0.001;
            alg.ParentsProportion = 0.5;
            alg.PopulationSize = 1000;
            

            //Asignamos una lista de valores para cada gen
            alg.Start();

            for (int i = 0; i < 9; i++ ) {
                Console.WriteLine(alg.Population.Members[i].ToString());
            }

                Console.WriteLine("Pulse una tecla para finalizar...");
            Console.ReadLine();

            
        }
    }
}
