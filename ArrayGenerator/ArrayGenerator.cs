using System;
namespace ArrayGeneratorSpace
{
    public class ArrayGenerator
    {
        private static Random randomizer = new Random();
        public static int[,] GetRandomArray(int arraySizeX, int arraySizeY)
        {
            int[,] arrayToFill = new int[arraySizeX,arraySizeY];
            //foreach (int value in arrayToFill)
            for (int indexX = 0, indexY = 0; indexX < arraySizeX, indexY < arraySizeY ; indexX++, indexY++)
            {
                arrayToFill[index] = randomizer.Next(-1000, 1000);
            }
            return arrayToFill;
        }
    }
}
