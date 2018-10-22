using System;
using ISorterNameSpace;

namespace BubbleSorterNameSpace
    {
    public class BubbleSorter : ISorter
    {
        private int accumulator = new int;
        private int[] tmpArray = new int[];
        public int[] Sort(int[] arrayToSort)
        { return tmpArray[]; }
        
        
        }
          
    }

        {
            
            //private static int[] swapElements(int[] inputArray, int indexA, int indexB)
  
            //{
            //    int accumulator = inputArray[indexB];
            //    inputArray[indexB] = inputArray[indexA];
            //    inputArray[indexA] = accumulator;
            //    return inputArray;
            //}
   
            //{
                bool elementsNotSwapped = true;
                while (elementsNotSwapped)
                //Sort untill no sapping is present
                {
                    elementsNotSwapped = false;
                    int index = 0;
                    do
                    {
                        if (arrayToSort[index] > arrayToSort[index + 1])
                        {
                            swapElements(arrayToSort, index + 1, index);
                            //WriteArray(arrayToSort, "Boubled ==>");
                            elementsNotSwapped = true;
                        }
                        index++;
                    }
                    while (index < arrayToSort.Length - 1);
                }

            }

            

            //throw new NotImplementedException();
        }

        //int[] ISorter.Sort(int[] arrayToSort, out int sortingTime)
        //{
        //    throw new NotImplementedException();
        }
    }
}
