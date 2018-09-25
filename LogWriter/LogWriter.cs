using System;
using System.IO;
using System.Reflection;

namespace LogWriterNameSpace
{
    public class LogWriter
    {
        //Contains Logfilename with current path
        private string currenExePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //Contains formatted day with time
        private string timeStamp = DateTime.Now.ToString("dd-MM-yyyy|HH:mm:ss|");
        //Appends log string with DayTime stamp
        public void Write(string logMessage)           
        {            
            try
            {
                File.AppendAllText(currenExePath + "\\" + "logFile.log", timeStamp + logMessage);
            }
            catch (Exception ex)
            {
            }
        }

    }
}

