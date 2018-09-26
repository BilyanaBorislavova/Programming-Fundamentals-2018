using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] arrTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < Math.Max(arrOne.Length, arrTwo.Length); i++)
            {
                var sum = arrOne[i % arrOne.Length] + arrTwo[i % arrTwo.Length];
                Console.Write($"{sum} ");
            }
        }
    }
}
