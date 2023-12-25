using System;

namespace ConsoleApp4315
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -2, 5, -5, 6, -6, 4, -4 };
            var nums = 0;
            for(int i = 0; i < array.Length; i++ )
            {
                if (array[i] > 0)
                    nums++;

            }
            Console.WriteLine("Положительных чисел {0}", nums);

        }
    }
}
