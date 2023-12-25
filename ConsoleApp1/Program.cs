using System;

namespace ConsoleApp1
{
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

    class Program
    {
        static void Main(string[] args)
        {
            const string Name = "Oleg";
            const int Age = 57;
            const bool There = true;
            const double Shoe = 37.5;

            Console.WriteLine("My name is {0}", Name);
            Console.WriteLine("My age is {0}", Age);
            Console.WriteLine("Do I have a pet ? {0}", There);
            Console.WriteLine("My shoe size is {0}", Shoe);

            DayOfWeek MyDay;
            MyDay = DayOfWeek.Friday;
            Console.WriteLine(MyDay);

            Semaphore SelectedColor;
            SelectedColor = Semaphore.Red;
            Console.WriteLine(SelectedColor);

            Console.WriteLine();
            Console.WriteLine("\tПривет,\n мир!");

            string MyName = "Евгения";
            Console.WriteLine("Привет, мир");
            Console.WriteLine();
            Console.WriteLine($"Меня зовут {MyName}, возраст {Age}");
            Console.WriteLine("Меня зовут {0}", MyName);
            Console.WriteLine("Меня зовут {0}", "Oleg");

            var name = "Oleg";
            var age = 57;
            var favcolor = "Black";
            Console.WriteLine("{0}\n  {1}\n {2} ", name, age, favcolor);
            Console.WriteLine("{0}\n  {1}\n {2} ", "Jane", "27", "black");

            Console.ReadKey();
        }
    }
}
