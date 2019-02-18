using System;
namespace SortersCommon
{
    public interface ISorter
    {
        // interface definition
        // Sorts input array and measure sorting time
        //int[,] Sort(int[,] arrayToSort, out double sortingTimeMs);

        event EventHandler SortingStart;
        event EventHandler<SortingIterationEndedEventArgs> SortingIterationEnded;
        event EventHandler<SortingEndedEventArgs> SortingEnd;


        int[] Sort(int[] arrayToSort);

    }
}