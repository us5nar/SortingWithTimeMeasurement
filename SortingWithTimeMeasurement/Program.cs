//using SortersTools;
//using System;
////using CommonNameSpace;

//namespace SortingWithTimeMeasurementCommon
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            LogWriter.Write("====================!!!START!!!=======================");
//            //Initialization of environment
//            string sotersPath = @"d:\Shared Plugins";
//            int arrayDimension = 10;
//            PathChecker.EnsurePathExists(sotersPath);        
//            Console.WriteLine("Init plugin directory {0}", sotersPath);
//            LogWriter.Write(String.Concat("Init plugin directory ",sotersPath));
//            LogWriter.Write(String.Format("Generating a new random 2d array {0}x{0}", arrayDimension));
//            //Generate a new array
//            int[,] unsortedArray = ArrayGenerator.GetRandomArray(arrayDimension, arrayDimension);
//            LogWriter.WriteArray(unsortedArray, "Input array");
//            ArrayWriter.WriteArray(unsortedArray, "Input array");
//            //AI - add input from keyboard
//            LogWriter.Write("Loading assemblies from shared folder");
//            PluginsLoader.LoadSortersFromDLLs(sotersPath);


//            LogWriter.Write("====================!!!STOP!!!=======================");
//            Console.ReadLine();


//        }
//    }
//}

//using System;
//using System.Threading; //Именно это пространство имен поддерживает многопоточность

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Thread myThread = new Thread(func); //Создаем новый объект потока (Thread)

//            myThread.Start(); //запускаем поток

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Поток 1 выводит " + i);
//                Thread.Sleep(0);
//            }

//            Console.Read(); //Приостановим основной поток

//        }

//        //Функция запускаемая из другого потока
//        static void func()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Поток 2 выводит " + i.ToString());
//                Thread.Sleep(0);
//            }
//        }

//    }
//}


using System;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        class myThread
        {
            Thread thread;

            public myThread(string name, int num) //Конструктор получает имя функции и номер до кторого ведется счет
            {

                thread = new Thread(this.func);
                thread.Name = name;
                thread.Start(num);//передача параметра в поток
            }

            void func(object num)//Функция потока, передаем параметр
            {
                for (int i = 0; i < (int)num; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                    Thread.Sleep(0);
                    //статический метод Thread.Sleep(0) приостанавливает поток вызвавший его на количество миллисекунд указанных в параметре. 0. Это означает что поток должен приостановиться для того чтобы дать возможность выполнения другому потоку.
                }
                Console.WriteLine(Thread.CurrentThread.Name + " завершился");
            }


        }

        static void Main(string[] args)
        {
            myThread t1 = new myThread("Thread 1", 10);
            myThread t2 = new myThread("Thread 2", 12);
            myThread t3 = new myThread("Thread 3", 5);

            Console.Read();

        }

    }
}
