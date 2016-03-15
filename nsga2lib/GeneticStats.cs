using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;

namespace nsga2lib
{
    public class GeneticStats
    {
        public int TotalMutations;
        public int TotalCrosses;
        public DateTime StartTime;
        public DateTime StopTime;

        public Chromosome BestIndividualChromosome;
        public int BestFitness;

        public PointPairList FitnessTime;
        public int Generation;
        public double MutationsPerIteration
        {
            get
            {
                if (RunningTime.Seconds > 0)
                    return Convert.ToDouble(1.0D * TotalMutations / Generation);
                else
                    return TotalCrosses;
            }
        }


        public TimeSpan RunningTime
        {
            get
            {
                return (DateTime.Now - StartTime);
            }
        }
        public Double RunningTimeMilliseconds
        {
            get
            {
                return ((RunningTime.Hours * 60 + RunningTime.Minutes) * 60 + RunningTime.Seconds) * 1000 + RunningTime.Milliseconds;
            }
        }
        public Double IterationsPerSecond
        {
            get
            {
                if (RunningTime.Seconds > 0)
                    return Convert.ToDouble(1000.0D * Generation / RunningTimeMilliseconds);
                else
                    return TotalCrosses;
            }
        }
        public Double CrossesPerSecond
        {
            get
            {
                if (RunningTime.Seconds > 0)
                    return Convert.ToDouble(1000.0D * TotalCrosses / RunningTimeMilliseconds);
                else
                    return TotalCrosses;
            }
        }
        public Double MutationsPerSecond
        {
            get
            {
                if (RunningTime.Seconds > 0)
                    return Convert.ToDouble(1000.0D * TotalMutations / RunningTimeMilliseconds);
                else
                    return TotalMutations;
            }
        }


        public GeneticStats()
        {
            FitnessTime = new PointPairList();
        }

        public void Start()
        {
            StartTime = DateTime.Now;
        }
        public void Stop()
        {
            StopTime = DateTime.Now;
        }
        public void RecordFitness(int fitnessValue)
        {
            FitnessTime.Add(RunningTime.TotalMilliseconds,Convert.ToDouble(fitnessValue));
        }
        public void AddMutation()
        {
            TotalMutations++;
        }
        public void AddCross()
        {
            TotalCrosses++;
        }


    }
}
