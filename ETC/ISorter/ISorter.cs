namespace ISorterNameSpace
{
    public interface ISorter
    {
        // interface definition
        // interface members:
        // Sort input array and measure sorting time
        int[] Sort(int[] arrayToSort, out double sortingTimeMs);
    }
}
