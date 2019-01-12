using System;
using System.IO;
using System.Reflection;

namespace SortersTools
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
            //try
            //{
            File.AppendAllText(currenExePath + "\\" + "logFile.log", timeStamp + logMessage + "\n\r");
            //}
            //catch (Exception ex)
            //{
            //}
        }
        public static void WriteArray(int[,] arrayToWrite, string arrayCaption)
        {
            int arraySizeA = arrayToWrite.GetLength(0);
            int arraySizeB = arrayToWrite.GetLength(1);
            Write("Dump of " + arrayCaption);
            Write("Size:" + arraySizeA + "x" + arraySizeB + "\n");
            for (int column = 0; column < arraySizeA; column++)
            {
                string rowToWrite = "";
                for (int row = 0; row < arraySizeB; row++)
                {
                    rowToWrite += String.Format("{0}\t", arrayToWrite[row, column].ToString());
                }
                File.AppendAllText(currenExePath + "\\" + "logFile.log", rowToWrite + "\n\r");
            }
            Write("==================End Of Dump========================");
        }
    }
}