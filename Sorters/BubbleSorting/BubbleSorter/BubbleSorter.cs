using SortersCommon;
using SortersTools;
using System;

namespace BubbleSorter
{
    internal class BubbleSorter : ISorter
    {
        public int[,] Sort(int[,] inputArray, out double sortingTimeMs)
        {
            // Bobble sorting method for interger array
            // Begin timing.
            DateTime timeStart = DateTime.Now;
            //Convert arrayToSort to 1d array
            int[] arrayToSort = ArrayConverter.ConvertTo1D(inputArray);

            //Precondition
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
            return ArrayConverter.ConvertTo2D(arrayToSort, inputArray.GetLength(0), inputArray.GetLength(1));
        }

    }
}