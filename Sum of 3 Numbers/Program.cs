﻿using System;

namespace Sum_of_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = int.Parse(Console.ReadLine());

            int number2 = int.Parse(Console.ReadLine());

            int number3 = int.Parse(Console.ReadLine());


            int sum = number1 + number2 + number3;

            Console.WriteLine(sum);

        }
    }
}
