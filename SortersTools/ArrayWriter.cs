using System;
namespace SortersTools
{
    public class ArrayWriter
    {
        public static void WriteArray(int[,] arrayToWrite, string caption)
        {
            //Environment Variables init
            int arrayLengthA = arrayToWrite.GetLength(0);
            int arrayLengthB = arrayToWrite.GetLength(1);
            //Output
            //Console.ForegroundColor=Cian
            Console.WriteLine("\nWriting " + caption + "\n");

            for (int countA = 0; countA < arrayLengthA; countA++)
            {
                for (int countB = 0; countB < arrayLengthB; countB++)
                {
                    //Console.Write("{0}\t", arrayToWrite[countA, countB]);
                    Console.Write("{0,6}", arrayToWrite[countA, countB]);

                }
                Console.WriteLine();
            }
        }
    }
}

