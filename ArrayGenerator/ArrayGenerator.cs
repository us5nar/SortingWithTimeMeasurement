using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGenerator
{
    class ArrayGenerator
    {
        private static Random r = new Random();

        public static int[] GetRandomArray(int arrySize)
        {
            SortedDictionary<double, int> sortedSet = new SortedDictionary<double, int>();

            for (int index = 0; index < arrySize; index++)
            {
                sortedSet.Add(r.NextDouble(), index);
            }
            return sortedSet.Select(x => x.Value).ToArray();
        }
    }
}
