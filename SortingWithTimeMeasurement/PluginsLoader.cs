using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SortersCommon;
using SortersTools;

//namespace PluginsLoader
namespace SortingWithTimeMeasurementCommon
{
    public class PluginsLoader
    {      
        public static List<ISorter> LoadSortersFromDLLs(string pathToSharedDLLs)
        {
            string[] files = Directory.GetFiles(pathToSharedDLLs, "*.dll");
            List<Assembly> assamblies = new List<Assembly>();
            foreach (string dllFile in files)
            {
                assamblies.Add(Assembly.LoadFile(dllFile));
                LogWriter.Write(dllFile);
            }
            List<ISorter> sorters = new List<ISorter>();
            foreach(Assembly assembly in assamblies)
            {
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (type.GetInterface(nameof(ISorter)) != null)
                    {
                        ConstructorInfo[] constructors = type.GetConstructors();
                        foreach (ConstructorInfo constructor in constructors)
                        {
                            if (constructor.GetParameters().Length == 0)
                            {
                                ISorter sorter = (ISorter)constructor.Invoke(null);
                                sorters.Add(sorter);
                                break;
                            }

                        }

                    }
                }
            }
            return sorters;
        }
    }
}
