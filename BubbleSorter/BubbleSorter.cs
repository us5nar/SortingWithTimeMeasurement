using ISorterNameSpace;

namespace BubbleSorterNameSpace
{
    public class BubbleSorter : ISorter
    {
        public int[] Sort(int[] arrayToSort, out int sortingTime)
        {
            // Bobble sorting method for interger array
            bool elementsWereSwapped = true;
            while (elementsWereSwapped)
            //Sort untill no sapping is present
            {
                elementsWereSwapped = false;
                int n = 0;
                //move element up
                foreach (int element in arrayToSort)
                {
                    if (arrayToSort[n] > arrayToSort[n + 1])
                    {
                        //swap Elements arrayToSort[n + 1] with arrayToSort[n]
                        int temp = arrayToSort[n];
                        arrayToSort[n] = arrayToSort[n + 1];
                        arrayToSort[n + 1] = temp;

                        elementsWereSwapped = true;
                    }
                    n++;
                }
            }
            //this time should be calculated
            sortingTime = 1;
            return arrayToSort;
        }
    }
}
       