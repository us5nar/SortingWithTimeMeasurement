using System;
using LogWriterNameSpace;
using ArrayGeneratorSpace;


namespace SortingWithTimeMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter logWriter = new LogWriter();
            int[] unsortedArray = ArrayGenerator.GetRandomArray(10);
            //An exapmple of log writer usage
            //-----------I want to try it as a static-------------
            logWriter.Write("====================!!!START!!!=======================");
            foreach (int element in unsortedArray)
            {
                logWriter.Write(element.ToString());
            }
            logWriter.Write("====================!!!STOP!!!=======================");



            Console.ReadLine();


        }
    }
}
