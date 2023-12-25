using System;

namespace ConsoleApp4316
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int nums = 0;
            foreach(var i in arr)
            {
                if (i > 0)
                    nums++;
            }
            Console.WriteLine("Положительных чисел {0}", nums);
        }
    }
}
