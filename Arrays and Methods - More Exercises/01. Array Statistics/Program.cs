using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] values = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            Console.WriteLine($"Min = {GetMin(values)}");
            Console.WriteLine($"Max = {GetMax(values)}");
            Console.WriteLine($"Sum = {GetSum(values)}");
            Console.WriteLine($"Average = {GetAverage(values)}");
        }

        static long GetMin(long[] n)
        {
            return n.Min();
        }

        static long GetMax(long[] n)
        {
            return n.Max();
        }

        static long GetSum(long[] n)
        {
            return n.Sum();
        }

        static double GetAverage(long[] n)
        {
            return n.Average();
        }
    }
}
