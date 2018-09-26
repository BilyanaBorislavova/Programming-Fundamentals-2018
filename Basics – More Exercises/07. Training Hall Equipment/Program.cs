using System;

namespace _07._Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfItems = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 0; i < numOfItems; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                totalPrice += price * count;


                if(count == 1)
                {
                    Console.WriteLine($"Adding {count} {name} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                }
                
            }

            Console.WriteLine($"Subtotal: ${totalPrice:f2}");

            if(budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough. We need ${moneyNeeded:f2} more.");
            }
        }
    }
}
