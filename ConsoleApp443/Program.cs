using System;

namespace ConsoleApp443
{
    class Program
    {
        static void Main(string[] args)
        {
            var anketa = (name: "oleg", age: 47);
            Console.WriteLine("Ваше имя {0}\nВаш возраст {1}", anketa.name, anketa.age);

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Подтвердите информацию");

                Console.WriteLine("Подтведите ваше имя");
                var name1 = Console.ReadLine();
                if (anketa.name != name1)
                {
                    Console.WriteLine("Подтверждение информации не пройдено");
                    continue;
                }
                else break;
            }

            while (true)
            {
                Console.WriteLine("Укажите ваш возраст");
                var sage = Console.ReadLine();
                int age = Convert.ToInt32(sage);
                if (anketa.age != age)
                {
                    Console.WriteLine("Подтверждение информации не пройдено");
                    continue;
                }
                else break;
            }
               

        }
    }
}
