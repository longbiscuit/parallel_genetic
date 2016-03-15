using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsga2lib
{
    /// <summary>
    /// Interfaz que debe implementar un componente de modelo de problema 
    /// para ser resuelto por el algoritmo genético
    /// </summary>
    public interface IProblemModel
    {
        /// <summary>
        /// Valor de una de las funciones objetivo a optimizar (minimizar).
        /// </summary>
        /// <param name="genes">Conjunto de genes sobre los que calcuar el 
        /// valor de la función objetivo</param>
        /// <param name="i">Selección de la función concreta a optimizar, 
        /// 1 para modelos monobjetivo</param>
        /// <returns>Valor según la función objetivo i-ésima</returns>
        int Fitness(int[] genes, int i);

        /// <summary>
        /// Devuelve el número de funciones objetivo que emplea el 
        /// modelo (1 o 2).
        /// </summary>
        int FitnessDimension { get; }

        /// <summary>
        /// Consulta si se cumple el criterio de parada.
        /// Se deja en modelo ya que puede estar establecido según parámetros 
        /// concretos del modelo
        /// </summary>
        /// <returns></returns>
        bool StoppingCriteria();

        /// <summary>
        /// Decodificación básica de un genotipo en su fenotipo (significado 
        /// real del conjunto de genes)
        /// </summary>
        /// <param name="genes">Genotipo a decodificar</param>
        /// <returns></returns>
        string Decode(int[] genes);

        /// <summary>
        /// Generación que se está procesando, establecida aquí para poder 
        /// consultar más adelante si se aplica criterio de parada.
        /// </summary>
        int Generation { get; set; }

        /// <summary>
        /// Combinaciones de valores posibles para los genes. 
        /// Pueden ser (0, 1) u otros.
        /// </summary>
        ArrayList GenValues { get; }

        /// <summary>
        /// Definición del tamaño base de los cromosomas para éste problema.
        /// </summary>
        int ChromosomeSize { get; }

    }
}
