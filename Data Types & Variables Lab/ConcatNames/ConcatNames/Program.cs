﻿using System;

namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{name}{delimeter}{surname}");
        }
    }
}
