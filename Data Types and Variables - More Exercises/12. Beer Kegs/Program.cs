using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> beers = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                beers.Add(model, volume);
            }

            foreach (var beer in beers.OrderByDescending(i => i.Value))
            {
                Console.WriteLine(beer.Key);
                break;
            }
        }
    }
}
