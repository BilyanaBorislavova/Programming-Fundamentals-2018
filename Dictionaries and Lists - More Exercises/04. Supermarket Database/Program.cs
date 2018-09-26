using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<double>> availableProducts = new Dictionary<string, List<double>>();

            while (products[0] != "stocked")
            {
                string name = products[0];
                double price = double.Parse(products[1]);
                double quantity = double.Parse(products[2]);

                if(!availableProducts.ContainsKey(name))
                {
                    availableProducts.Add(name, new List<double>());
                    availableProducts[name].Add(price);
                    availableProducts[name].Add(quantity);
                }
                else
                {
                    availableProducts[name][0] = price;
                    availableProducts[name][1] += quantity;
                }


                products = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            double totalSum = 0;

            foreach (var item in availableProducts)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]} = ${item.Value[0] * item.Value[1]:f2}");
                totalSum += item.Value[0] * item.Value[1];
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalSum:f2}");
        }
    }
}
