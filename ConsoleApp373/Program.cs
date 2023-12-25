using System;

namespace ConsoleApp373
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked ((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            // 1
            //Console.Write("What is your favorite day of week ? ");
            //byte fav_day = checked((byte)int.Parse(Console.ReadLine()));
            //Console.WriteLine("Your favorite day of week {0}", (DayOfWeek)fav_day);

            // 2
            Console.Write("What is your favorite day of week ? ");
            DayOfWeek fav_day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day of week {0}", fav_day);

            Console.Write("Enter your birthday ? ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day of week {0}", birthday.ToString("dd.MM.yyyy"));

            Console.ReadKey();

        }
    }
}
