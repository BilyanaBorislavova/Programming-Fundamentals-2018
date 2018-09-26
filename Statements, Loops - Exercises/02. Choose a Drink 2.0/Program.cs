using System;

namespace _02._Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double waterPrice = 0.7 * quantity;
            double coffeePrice = 1 * quantity;
            double beerPrice = 1.7 * quantity;
            double teaPrice = 1.2 * quantity;

            if(profession == "Athlete")
            {
                Console.WriteLine($"The {profession} has to pay {waterPrice:f2}.");
            }
            else if(profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {coffeePrice:f2}.");
            }
            else if(profession == "SoftUni Student")
            {
                Console.WriteLine($"The {profession} has to pay {beerPrice:f2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {teaPrice:f2}.");
            }
        }
    }
}
