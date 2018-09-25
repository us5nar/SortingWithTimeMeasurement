using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogWriterNameSpace;

namespace SortingWithTimeMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter logWriter = new LogWriter();
            //An exapmple of log writer usage
            //-----------I want to try it as a static-------------
            logWriter.Write("START!!!");
            Console.ReadLine();


        }
    }
}
