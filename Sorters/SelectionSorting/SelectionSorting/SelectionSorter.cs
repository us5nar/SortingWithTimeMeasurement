using System;
using CommonNameSpace;
using Tools;

namespace SelectionSorting
{
    public class SelectionSorter : ISorter
    {
        public int[,] Sort(int[,] arrayToSort, out double sortingTimeMs)
        {
            // Init Stopwatch.
            DateTime timeStart = DateTime.Now;
            a
            int lengthA = arrayToSort.GetLength(0);
            int lengthB = arrayToSort.GetLength(1);
            int[] temporaryArray = Arr.ConvertTo1D(arrayToSort);

            // Init Variables.
            int maxElementPositionInRow = arrayToSort.GetLength(0) - 1;
            int maxElementPositionInColumn = arrayToSort.GetLength(1) - 1; // with respect to 0.
            int element2Swap = 0;
            int temporaryArraySize = arrayToSort.GetLength(0) * arrayToSort.GetLength(1);
            //int[] temporaryArray = new int[temporaryArraySize];


            // copy 2d array to 1d accumiulator
            int position = 0;
            foreach (int element in arrayToSort)
                {temporaryArray[position++] = element;}

            //Selection Sorting of temporary array 
            for (int counter_i = 0; counter_i < temporaryArraySize; counter_i++)
            {
                int minElement = counter_i;
                for (int counter_j = counter_i + 1; counter_j < temporaryArraySize; counter_j++)
                {
                    if (temporaryArray[counter_j] < temporaryArray[minElement])
                    {
                        minElement = counter_j;
                    }
                }
                element2Swap = temporaryArray[counter_i];
                temporaryArray[counter_i] = temporaryArray[minElement];
                temporaryArray[minElement] = element2Swap;
            }

            //Retun 2d array
            position = 0;
            for (int i = 0; i <= maxElementPositionInRow; i++)
            {
                for (int j = 0; j <= maxElementPositionInColumn; j++)
                {
                    arrayToSort[i, j] = temporaryArray[position++];
                }                
            }
            // Calculating delta.
            TimeSpan timeDelta = DateTime.Now - timeStart;
            // Returns Elapsed time in Milliseconds;
            sortingTimeMs = timeDelta.TotalMilliseconds;
            return arrayToSort;
         }
    }
}