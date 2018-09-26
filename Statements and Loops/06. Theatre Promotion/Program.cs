﻿using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if(day == "Weekday")
            {
                if(0 <= age && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if(18 < age && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if(64 < age && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

            if(day == "Weekend")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

            if(day == "Holiday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }


        }
    }
}
