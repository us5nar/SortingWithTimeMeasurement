using System;
using ISorterNameSpace;
namespace BubbleSorterNameSpace
{
    internal class InsertionSorter : ISorter
    {
        public int[] Sort(int[] arrayToSort, out double sortingTimeMs)
        {
            // Bobble sorting method for interger array
            // Begin timing.
            DateTime timeStart = DateTime.Now;
            //Init:
            //Condition
            bool elementsWereSwapped = true;
            //Array Size
            int arraySize = arrayToSort.Length - 1;
            while (elementsWereSwapped)                      //Sort untill no sapping is present
            {
                elementsWereSwapped = false;
                //move element up
                for (int n = 0; n < arraySize; n++)
                {
                    if (arrayToSort[n] > arrayToSort[n + 1]) //swap Elements arrayToSort[n + 1] with arrayToSort[n]
                    {
                        int temp = arrayToSort[n];
                        arrayToSort[n] = arrayToSort[n + 1];
                        arrayToSort[n + 1] = temp;

                        elementsWereSwapped = true;
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

    }
}