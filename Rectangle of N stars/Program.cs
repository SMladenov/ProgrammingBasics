﻿using System;

namespace Rectangle_of_N_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('*', n));
            }

        }
    }
}
