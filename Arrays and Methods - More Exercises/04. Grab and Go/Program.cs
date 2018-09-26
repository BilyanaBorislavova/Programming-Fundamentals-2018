using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long n = long.Parse(Console.ReadLine());

            if (!numbers.Contains(n))
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                var lastEl = numbers.LastIndexOf(n);
                var newList = numbers.Take(lastEl).Sum();
                Console.WriteLine(newList);
            }
        }
    }
}
