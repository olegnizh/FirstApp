﻿using System;

namespace ConsoleApp43next
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }


            foreach (var color in favcolors)
            {
                foreach (var item in color)
                {
                    Console.Write(item + " ");
                }
            }




        }
    }
}
