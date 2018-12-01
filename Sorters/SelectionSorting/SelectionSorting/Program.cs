using System;
namespace SelectionSorting

{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация массива.
            int[,] array = {{4,3,1,2},
                            {4,6,7,6},
                            {8,4,1,5}};



            // Инициализация переменных.
            int max_size_strok = array.GetLength(0) - 1; // Отчет с нуля (для удобства).
            // Пример: 3 4 1  max_size_strok     == 2 - 1 == 1     [0,0] [0,1] [0,2]
            //         5 2 9  max_size_stolbtsov == 3 - 1 == 2     [1,0] [1,1] [1,2]
            int max_size_stolbtsov = array.GetLength(1) - 1; // Отчет с нуля (для удобства).
            //int save = 0; // Помогает менять местами элементы массива.            
            //Вывод массива.
            Console.WriteLine("Исходный массив:\n");
            for (int i = 0; i <= max_size_strok; i++)
            {
                for (int j = 0; j <= max_size_stolbtsov; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            int tempArrayLength = array.GetLength(0) * array.GetLength(1);
            //int[] tempArray = new int[tempArrayLength];
            //int position = 0;
            //foreach (int element in array) { tempArray[position++] = element; } ;
            //////----------------------------------------Сортировка массива ВСТАВКАМИ.
            ////tempArrayLenrth = tempArray.Length;
            ////for (int j = 0; j <= tempArrayLength; j++)
            ////{
            ////    for (int i = 0; i < tempArrayLength - 1; i++)
            ////        if (tempArray[i] > tempArray[i + 1])
            ////        {
            ////            save = tempArray[i];
            ////            tempArray[i] = tempArray[i + 1];
            ////            tempArray[i + 1] = save;
            ////        }
            ////}
            //////----------------------------------------Сортировка массива ВСТАВКАМИ.
            ////------------------------------------------Сортировка массива ВЫБОРОМ.

            //for (int i = 0; i < tempArrayLength; i++)
            //{
            //    int min = i;

            //    for (int j = i + 1; j < tempArrayLength; j++)
            //    {
            //        if (tempArray[j] < tempArray[min])
            //        {
            //            min = j;
            //        }
            //    }

            //    save = tempArray[i];
            //    tempArray[i] = tempArray[min];
            //    tempArray[min] = save;
            //}
            ////------------------------------------------Сортировка массива ВЫБОРОМ.



            ////Вывод массива.
            ////Array.Sort(tempArray);
            //position = 0;
            //foreach (int element in tempArray) { Console.Write("{1}:{0}\t", tempArray[position++], position); }
            //position = 0;
            //for (int i = 0; i <= max_size_strok; i++)
            //{
            //    for (int j = 0; j <= max_size_stolbtsov; j++)
            //    {
            //        array[i, j] = tempArray[position++];                   
            //    }
            //    Console.WriteLine();
            //}


            ////array = SelectionSorter.Sort

            SelectionSorter sorter = new SelectionSorter();
            array = sorter.Sort(array, out double elapsedTime);

            Console.WriteLine("\nОтсортированный массив:\n");
            for (int i = 0; i <= max_size_strok; i++)
            {
                for (int j = 0; j <= max_size_stolbtsov; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            // Задержка.
            Console.ReadKey();
        }
    }
}
