using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Calorie_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string ingredients = Console.ReadLine();

            int total = 0;
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;

            for (int i = 1; i <= num; i++)
            {
                if(ingredients.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
                {
                    total += cheese;
                }
                if(ingredients.Equals("tomato sauce",StringComparison.CurrentCultureIgnoreCase))
                {
                    total += tomatoSauce;
                }
                if(ingredients.Equals("salami", StringComparison.CurrentCultureIgnoreCase))
                {
                    total += salami;
                }
                if(ingredients.Equals("pepper", StringComparison.CurrentCultureIgnoreCase))
                {
                    total += pepper;
                }

                ingredients = Console.ReadLine();
            }

            Console.WriteLine($"Total calories: {total}");
        }
    }
}
