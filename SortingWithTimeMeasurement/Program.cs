using SortersTools;
using System;
//using CommonNameSpace;

namespace SortingWithTimeMeasurementCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter.Write("====================!!!START!!!=======================");
            //Initialization of environment
            string sotersPath = @"d:\Shared Plugins";
            int arrayDimension = 10;
            PathChecker.EnsurePathExists(sotersPath);        
            Console.WriteLine("Init plugin directory {0}", sotersPath);
            LogWriter.Write(String.Concat("Init plugin directory ",sotersPath));
            LogWriter.Write(String.Format("Generating a new random 2d array {0}x{0}", arrayDimension));
            //Generate a new array
            int[,] unsortedArray = ArrayGenerator.GetRandomArray(arrayDimension, arrayDimension);
            LogWriter.WriteArray(unsortedArray, "Input array");
            ArrayWriter.WriteArray(unsortedArray, "Input array");
            //AI - add input from keyboard
            LogWriter.Write("Loading assemblies from shared folder");
            PluginsLoader.LoadSortersFromDLLs(sotersPath);


            LogWriter.Write("====================!!!STOP!!!=======================");
            Console.ReadLine();


        }
    }
}
