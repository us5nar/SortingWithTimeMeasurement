using SortersTools;
using System;

namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = ArrayGenerator.GetRandomArray(10, 10);
            BubbleSorter sorter = new BubbleSorter();
            ArrayWriter.WriteArray(numbers, "Original Array");
            ArrayWriter.WriteArray(sorter.Sort(numbers, out double timer), "Sorted Array with time " + timer);
            Console.ReadLine();
        }
    }
}