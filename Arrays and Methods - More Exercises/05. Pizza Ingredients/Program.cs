using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ingredients = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            long length = long.Parse(Console.ReadLine());

            List<string> newIngredients = new List<string>();

            foreach (var item in ingredients)
            {
                if(item.Length == length)
                {
                    newIngredients.Add(item);
                    Console.WriteLine($"Adding {item}.");

                    if(newIngredients.Count >= 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {newIngredients.Count()} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", newIngredients)}.");
        }
    }
}
