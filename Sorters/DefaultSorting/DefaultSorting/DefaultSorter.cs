using System;
using ISorterNameSpace;

namespace DefaultSorting
{
    class DefaultSorter:ISorter
    {
        public int[] Sort(int[] arrayToSort, out double sortingTimeMs)
        {
            // Begin timing.
            DateTime timeStart = DateTime.Now;
            //Sort using default sorter 
            Array.Sort(arrayToSort);
            // Calculating delta.
            TimeSpan timeDelta = DateTime.Now - timeStart;
            // Returns Elapsed time in Milliseconds;
            sortingTimeMs = timeDelta.TotalMilliseconds;
            //Retuns sorted array
            return arrayToSort;
        }


    }
}
