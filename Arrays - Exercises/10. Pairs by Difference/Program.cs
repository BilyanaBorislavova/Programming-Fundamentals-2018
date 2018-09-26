using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int difference = int.Parse(Console.ReadLine());

            int count = 0;

            foreach (var item in n)
            {
                foreach (var itemm in n)
                {
                    if(item - itemm == difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
