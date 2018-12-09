using SortersTools;
using System;
//using CommonNameSpace;


namespace SortingWithTimeMeasurementCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            //TBD Generate a new array
            //AI - add input from keyboard
            int[,] unsortedArray = ArrayGenerator.GetRandomArray(10, 10);

            //An exapmple of log writer usage
            LogWriter.Write("====================!!!START!!!=======================");

            //Check array output to log
            LogWriter.WriteArray(unsortedArray, "Input array");

            //Ceck Array printing           
            ArrayWriter.WriteArray(unsortedArray, "Input array");

            LogWriter.Write("====================!!!STOP!!!=======================");

            Console.ReadLine();


        }
    }
}
