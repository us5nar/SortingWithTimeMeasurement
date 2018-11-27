using System;
using System.IO;
using System.Reflection;

namespace LogWriterNameSpace
{
    public static class LogWriter
    {
        //Contains Logfilename with current path
        private static string currenExePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //Contains formatted day with time
        private static string timeStamp = DateTime.Now.ToString("dd-MM-yyyy | HH:mm:ss | ");
        //Appends log string with DayTime stamp
        public static void Write(string logMessage)           
        {            
            try
            {
                File.AppendAllText(currenExePath + "\\" + "logFile.log", timeStamp + logMessage + "\n\t");
            }
            catch (Exception ex)
            {
            }
        }

    }
}

