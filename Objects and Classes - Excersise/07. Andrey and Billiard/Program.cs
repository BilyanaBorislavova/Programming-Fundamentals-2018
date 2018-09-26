using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> availableProducts = new Dictionary<string, double>();
            List<string> avProducts = new List<string>();

            Dictionary<string, Dictionary<string, int>> clients = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string product = data[0];
                double price = double.Parse(data[1]);
                avProducts.Add(product);

                if (!availableProducts.ContainsKey(product))
                {
                    availableProducts.Add(product, price);
                }
                else
                {
                    availableProducts[product] = price;
                }
            }

            while (true)
            {
                string[] customerData = Console.ReadLine()
                .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (customerData[0] == "end of clients")
                {
                    break;
                }

                string customer = customerData[0];
                string productWanted = customerData[1];
                int quantity = int.Parse(customerData[2]);

                if (avProducts.Contains(productWanted))
                {
                    if (!clients.ContainsKey(customer))
                    {
                        clients.Add(customer, new Dictionary<string, int>());
                    }

                    if (!clients[customer].ContainsKey(productWanted))
                    {
                        clients[customer].Add(productWanted, quantity);
                    }
                    else
                    {
                        clients[customer][productWanted] += quantity;
                    }
                }

            }

            double totalSum = 0;
            List<double> bill = new List<double>();

            foreach (var person in clients.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{person.Key}");

                foreach (var item in person.Value)
                {
                    foreach (var product in availableProducts)
                    {
                        if (item.Key.Contains(product.Key))
                        {
                            Console.WriteLine($"-- {item.Key} - {item.Value}");
                            bill.Add(product.Value * item.Value);
                            totalSum += product.Value * item.Value;
                        }
                    }
                }
                Console.WriteLine($"Bill: {bill.Sum():f2}");
                bill.Clear();
            }

            Console.WriteLine($"Total bill: {totalSum:f2}");
        }

    }
}
