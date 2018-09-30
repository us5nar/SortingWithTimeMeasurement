using System;
using LogWriterNameSpace;
using ArrayGeneratorSpace;


namespace SortingWithTimeMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] unsortedArray = ArrayGenerator.GetRandomArray(10);
                      


            LogWriter logWriter = new LogWriter();
            //An exapmple of log writer usage
            //-----------I want to try it as a static-------------
            logWriter.Write("START!!!");
            Console.ReadLine();


        }
    }
}
