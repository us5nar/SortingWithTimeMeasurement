using System;
using LogWriterNameSpace;
using ArrayGeneratorSpace;


namespace SortingWithTimeMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            //LogWriter logWriter = new LogWriter();
            int[] unsortedArray = ArrayGenerator.GetRandomArray(10);
            //An exapmple of log writer usage
            //-----------I want to try it as a static-------------
            LogWriter.Write("====================!!!START!!!=======================");
            foreach (int element in unsortedArray)
            {
                LogWriter.Write(element.ToString());
            }
            LogWriter.Write("====================!!!STOP!!!=======================");

            Console.ReadLine();


        }
    }
}
