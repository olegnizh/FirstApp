using System;

namespace ConsoleApp445
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("");
            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Вы ввели имя питомца - {0}", Pet.Name);

            Console.WriteLine("");
            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Вы ввели вид питомца - {0}", Pet.Type);

            Console.WriteLine("");
            Console.WriteLine("Введите возрас питомца");
            Pet.Age = double.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели возрас питомца - {0}", Pet.Age);

        }
    }
}
