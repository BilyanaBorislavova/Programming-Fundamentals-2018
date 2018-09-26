using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (var num in arr)
            {
                double roundedNum = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {roundedNum}");

            }
        }
    }
}
