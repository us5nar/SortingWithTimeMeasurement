using System;
namespace ArrayGeneratorSpace
{
    public class ArrayGenerator
    {
        private static Random randomizer = new Random();
        public static int[,] GetRandomArray(int arraySizeX, int arraySizeY)
        {
            int[,] arrayToFill = new int[arraySizeX,arraySizeY];
            //for each position in array generate a rendom value
            for (int indexX = 0; indexX < arraySizeX; indexX++)
            {
                for (int indexY = 0; indexY < arraySizeY; indexY++)
                {
                    arrayToFill[indexX, indexY] = randomizer.Next(-1000, 1000);
                }
            }
            return arrayToFill;
        }
    }
}
