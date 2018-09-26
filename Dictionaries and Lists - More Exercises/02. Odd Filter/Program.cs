using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var oddNumbers = data.Where(a => a % 2 == 0).ToList();
            var averageNum = oddNumbers.Average();


            for (int i = 0; i < oddNumbers.Count; i++)
            {
                if(oddNumbers[i] > averageNum)
                {
                    oddNumbers[i] += 1;
                }
                else
                {
                    oddNumbers[i] -= 1;
                }

            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }
    }
}
