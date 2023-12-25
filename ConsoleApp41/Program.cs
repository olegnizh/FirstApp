using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;
            var result = (myapples != hispeares) & (myapples < hisapples);
            Console.WriteLine(result);

            string A = "a";
            string B = "v";
            bool C = A != B;
            Console.WriteLine(C);

            // 4.1.10
            var inv = true;
            var result1 = !inv;
            Console.WriteLine(result1);

            var a = 6;
            var b = 7;
            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }

            // 4.1.15
            var c = a != b ? a + b : b;
            Console.WriteLine(c);

            // 4.1.16
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color1 = Console.ReadLine();
            if (color1 == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is red!");
            }
            else if (color1 == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is cyan!");
            }

            // 4.1.18
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            Console.ReadLine();
           


        }
    }
}
