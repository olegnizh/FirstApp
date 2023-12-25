using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
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
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }
            */
            /*
            // 2
            Console.WriteLine("Цикл while");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(k);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red" :
                        k++;
                        break;
                    case "green":
                        k++;
                        break;
                    case "cyan":
                        k++;
                        break;
                    default:                        
                        break;
                }      
            }
            */
            
            //3
            int n = 0;
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(n);
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                switch (text)
                {
                    case "red":
                        n++;
                        Console.WriteLine("Вы иыбрали номером {0} цвет {1}", n, text);
                        break;
                    case "green":
                        n++;
                        Console.WriteLine("Вы иыбрали номером {0} цвет {1}", n, text);
                        break;
                    case "cyan":
                        n++;
                        Console.WriteLine("Вы иыбрали номером {0} цвет {1}", n, text);
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали ничего");
                        break;
                }
            }
            

        }
    }
}
