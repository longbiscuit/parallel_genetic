using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsga2lib
{
    public class RandomComparer : IComparer<Individual>
    {
        public int Compare(Individual x, Individual y)
        {
            if (x == y) return 0;
            return RandomGenerator.Next(-1, 1);
        }
    }
}
