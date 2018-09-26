using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = n.Length / 4;

            int[] leftPart = n.Take(k).Reverse().ToArray();
            int[] rightPart = n.Reverse().Take(k).ToArray();

            int[] rowOne = leftPart.Concat(rightPart).ToArray();
            int[] rowTwo = n.Skip(k).Take(2 * k).ToArray();

            var sum = rowOne.Select((x, index) => x + rowTwo[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
