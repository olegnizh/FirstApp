using System;

namespace FirstApp
{
    class Program
    {

 
        static void Main(string[] args)
        {

            //double result = 5.0 / 2.0;
            double result = 5.0 % 2.0;
            //Console.WriteLine("5 / 2 = {0}", result);            
            Console.WriteLine("5.0 % 2.0 = {0}", result);

            double result1 = 5.0 / 2.0 * 3.0;
            Console.WriteLine("5.0 / 2.0 * 3.0 = {0}", result1);

            double result2 = 10 % 3;
            Console.WriteLine("10 % 3 = {0}", result2);

            Console.ReadKey();

        }
    }
}
