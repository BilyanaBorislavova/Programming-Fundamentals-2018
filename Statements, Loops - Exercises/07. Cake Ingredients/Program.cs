using System;
using System.Collections;
using System.Collections.Generic;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();

            int count = 0;

            while (ingredient != "Bake!")
            {
                count++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
