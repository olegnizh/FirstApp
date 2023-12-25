using System;

namespace ConsoleApp439
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            //Console.WriteLine(array.Length);
            Console.WriteLine(" ");
            Console.WriteLine(array.GetUpperBound(0));  // не работает !!!!

            Console.WriteLine(" ");

            Console.Write("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            Console.ReadKey();
        }
    }
}
