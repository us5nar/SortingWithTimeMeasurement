using System;
namespace DefaultSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6, 88, -100, 3 };
            DefaultSorter sorter = new DefaultSorter();
            Console.WriteLine("\nOriginal Array Elements :");
            PrintIntegerArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            PrintIntegerArray(sorter.Sort(numbers, out double timer));
            Console.WriteLine("\nTme elapsed {0} ms.", timer);
            Console.WriteLine("\nPress ENTER to exit");
            Console.ReadLine();
        }

       static void PrintIntegerArray(int[] array)
        {
            Console.Write("[ ");
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
            Console.WriteLine("]");
        }
    }
}

