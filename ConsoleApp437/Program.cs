using System;

namespace ConsoleApp437
{
    
    class Program
    {
        static void Main(string[] args)
        {

            string name = "oleg";
            string name1 = "";
            for (int i = name.Length - 1; i >= 0; i--)
                name1 = name1 + name[i];

            Console.WriteLine("Имя {0} - буквы в обратном порядке {1}", name, name1);

            Console.ReadKey();


        }
    }
}
