﻿using System;
using LogWriterNameSpace;
using ArrayGeneratorSpace;


namespace SortingWithTimeMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            //LogWriter logWriter = new LogWriter();
            int[] unsortedArray = ArrayGenerator.GetRandomArray(200);
            //An exapmple of log writer usage
            //-----------I want to try it as a static-------------
            LogWriter.Write("====================!!!START!!!=======================");
            string lineForOutput="";
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
