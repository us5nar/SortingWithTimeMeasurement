using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace SortersTools
namespace SortingWithTimeMeasurementCommon
{
    class PathChecker
    {
        public static void EnsurePathExists(string path)
        {
            // ... Set to folder path we must ensure exists.
            try
            {
                // ... If the directory doesn't exist, create it.
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
                // Fail silently.
            }
        }

}
}
