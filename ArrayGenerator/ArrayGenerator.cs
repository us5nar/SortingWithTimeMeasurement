using System;

namespace ArrayGeneratorSpace
{
    public class ArrayGenerator
    {
        private static Random randomizer = new Random();

        public static int[] GetRandomArray(int arraySize)
        {
            int[] arrayToFill = new int[arraySize];

            for (int index = 0; index < arraySize; index++)
            {
                arrayToFill[index] = randomizer.Next(-1000,1000);
            }
            return arrayToFill;
        }
    }
}
