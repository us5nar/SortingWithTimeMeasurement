using System;
using ISorterNameSpace;

namespace InsertionSorterNaneSpace
{
    internal class InsertionSorter:ISorter
    {
         public int[] Sort(int[] arrayToSort, out double sortingTimeMs)
        {
            // Begin timing.
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arrayToSort[j - 1] > arrayToSort[j])
                    {
                        int temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }
            // Calculating delta.
            TimeSpan timeDelta = DateTime.Now - timeStart;
            // Returns Elapsed time in Milliseconds;
            sortingTimeMs = timeDelta.TotalMilliseconds;
            //Retuns sorted array
            return arrayToSort;
        }

        internal static int[] Sort(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
