using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i], 1);
                }
                else
                {
                    numbersCount[numbers[i]]++;
                }
            }

            foreach (var num in numbersCount)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
