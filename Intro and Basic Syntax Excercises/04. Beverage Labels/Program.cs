using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContentPer100ml = double.Parse(Console.ReadLine());
            double sugarContentPer100ml = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");

            double totalCalories = (energyContentPer100ml * volume) / 100;
            double totalSugar = (sugarContentPer100ml * volume) / 100;

            Console.WriteLine($"{totalCalories}kcal, {totalSugar}g sugars");
        }
    }
}
