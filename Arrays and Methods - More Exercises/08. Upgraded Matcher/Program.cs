using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<long> quantity = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(long.Parse)
               .ToList();

            List<decimal> price = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(decimal.Parse)
              .ToList();

            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            long sum = 0;
            while (command[0] != "done")
            {
                string currentProduct = command[0];
                long quantityOrdered = long.Parse(command[1]);

                var productIndex = products.IndexOf(command[0]);
                var product = products.ElementAt(productIndex);
                var priceProduct = price.ElementAt(productIndex);


                try
                {
                    var availableQuantity = quantity.ElementAt(productIndex);

                    decimal total = priceProduct * quantityOrdered;
                    if(availableQuantity < quantityOrdered)
                    {

                    }
                    else
                    {

                    }
                    
                    if (sum > availableQuantity)
                    {
                        Console.WriteLine($"We do not have enough {product}");

                    }
                    else
                    {
                        Console.WriteLine($"{product} x {quantityOrdered} costs {total:f2}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"We do not have enough {product}");
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray(); ;
            }

        }
    }
}
