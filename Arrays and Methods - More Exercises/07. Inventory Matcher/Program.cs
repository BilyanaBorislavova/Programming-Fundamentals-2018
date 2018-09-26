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

            string command = Console.ReadLine();

            while (command != "done")
            {
                var productIndex = products.IndexOf(command);

                var product = products.ElementAt(productIndex);
                var availableQuantity = quantity.ElementAt(productIndex);
                var priceProduct = price.ElementAt(productIndex);

                Console.WriteLine($"{product} costs: {priceProduct}; Available quantity: {availableQuantity}");
                
                command = Console.ReadLine();
            }

        }
    }
}
