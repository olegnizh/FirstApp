using System;

namespace ConsoleApp4311
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //Console.WriteLine("by rows");
            Console.WriteLine();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }

            //Console.WriteLine("by cols");
            Console.WriteLine();
            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                    //for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
