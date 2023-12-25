using System;

namespace ConsoleApp4313sm
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sm = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sm = sm + arr[i];				

			}
            Console.WriteLine("Сумма в массиве = {0}", sm);

			Console.ReadKey();
        }
    }
}
