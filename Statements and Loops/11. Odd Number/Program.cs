﻿using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while(n % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                n = int.Parse(Console.ReadLine());
            }
            if(n % 2 != 0)
            {
                Console.WriteLine("The number is: {0}", Math.Abs(n));
            }
        }
    }
}
