namespace SortersTools
{
    class ArrayConverter
    {
        public static int[] ConvertTo1D(int[,] input2dArray)
        {   // copy 2d array to 1d accumiulator
            int lengthA = input2dArray.GetLength(0);// - 1;
            int LengthB = input2dArray.GetLength(1);// - 1;
            int[] tempArray = new int[lengthA*LengthB];
            int position = 0;
            foreach (int element in input2dArray)
            {
                tempArray[position++] = element;
            }
            return tempArray;
        }
        public static int[,] ConvertTo2D(int[] input1dArray, int lengthA, int lengthB)
        {
            int[,] tempArray = new int[lengthA, lengthB];
            int count = 0;
            for (int countA = 0; countA < lengthA; countA++)
            {
                for (int countB = 0; countB < lengthB; countB++)
                {
                    tempArray[countA, countB] = input1dArray[count++];
                }
            }
            return tempArray;
        }
        


}
}
