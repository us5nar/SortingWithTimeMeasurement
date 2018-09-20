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
            logWriter.LogWrite("START!!!");
        }
    }
}
