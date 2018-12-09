namespace SortersCommon
{
    public interface ISorter
    {
        // interface definition
        // Sorts input array and measure sorting time
        int[,] Sort(int[,] arrayToSort, out double sortingTimeMs);
    }
}