using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }          

            for (int k = 0; k < favcolors.Length; k++)
            {                
                switch (favcolors[k])
                {
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет cyan");
                        break;
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет red");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет green");
                        break;
                }                   
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            */

            // 2
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Ваше имя по буквам");
            //for (int k = 0; k < name.Length; k++)
            //{
            //    Console.Write(name[k]);
            //    Console.Write(" ");                
            //}
            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }
            Console.Write("Последняя буква {0}", name[name.Length - 1]);

            



        }
    }
}
