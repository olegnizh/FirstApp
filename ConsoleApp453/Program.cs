﻿using System;

namespace ConsoleApp453
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            Console.WriteLine("Введите имя");

            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");

            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин");

            User.Login = Console.ReadLine();

            User.LoginLength = User.Login.Length;
            Console.WriteLine("Длина логина {0}", User.LoginLength);



        }
    }
}
