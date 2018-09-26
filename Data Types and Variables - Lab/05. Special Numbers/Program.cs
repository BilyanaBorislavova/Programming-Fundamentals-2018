using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());

            int total = 0; int sum = 0; bool trueOrFalse = false;

            for (int i = 1; i <= nums; i++)
            {
                sum = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                trueOrFalse = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{sum} -> {trueOrFalse}");
                total = 0;
                i = sum;
            }

        }
    }
}
