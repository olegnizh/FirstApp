using System;

namespace ConsoleApp442
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.WriteLine("Укажите ваше имя");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Укажите ваш возраст");
            var sage = Console.ReadLine();
            anketa.age = Convert.ToInt32(sage);

            Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa.Item2);
            Console.ReadKey();

        }
    }
}
