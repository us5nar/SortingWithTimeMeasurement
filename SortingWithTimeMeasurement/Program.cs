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
            int[,] unsortedArray = ArrayGenerator.GetRandomArray(20, 20);

            //An exapmple of log writer usage
            LogWriter.Write("====================!!!START!!!=======================");

            //Check array output to log
            LogWriter.WriteArray(unsortedArray, "Input array");

            //Ceck Array printing

            //ArrayWriter
            //SortersTools.ArrayWriter


            string lineForOutput = "";
            foreach (int element in unsortedArray)
            {
                lineForOutput += String.Format("{0}\t", element.ToString());
            }
            lineForOutput += "\n\r";
            LogWriter.Write(lineForOutput);
            Console.Write(lineForOutput);
            LogWriter.Write("====================!!!STOP!!!=======================");

            Console.ReadLine();


        }
    }
}
