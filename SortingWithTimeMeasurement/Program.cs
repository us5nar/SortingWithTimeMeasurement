using SortersTools;
using System;
//using CommonNameSpace;

namespace SortingWithTimeMeasurementCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization of environment
            
            PathChecker.EnsurePathExists(@"d:\Shared Plugins");        
            Console.WriteLine("DONE");
            //TBD Generate a new array
            //AI - add input from keyboard
            int[,] unsortedArray = ArrayGenerator.GetRandomArray(10, 10);

            //An exapmple of log writer usage
            LogWriter.Write("====================!!!START!!!=======================");
            
            //Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.CurrentDirectory);
            //Check array output to log
            LogWriter.WriteArray(unsortedArray, "Input array");

            //Ceck Array printing           
            ArrayWriter.WriteArray(unsortedArray, "Input array");
            LogWriter.Write("Loading asseblies from shared folder");



            LogWriter.Write("====================!!!STOP!!!=======================");

            Console.ReadLine();


        }
    }
}
