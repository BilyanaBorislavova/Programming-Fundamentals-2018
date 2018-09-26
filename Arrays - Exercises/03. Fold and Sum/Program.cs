using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
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

            int[] leftPart = n.Take(k).ToArray();
            int[] middlePart = n.Skip(k).Take(k * 2).ToArray();
            int[] rightPart = n.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftPart);
            Array.Reverse(rightPart);

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = middlePart[i] + leftPart[i];
                result[i + k] = middlePart[i + k] + rightPart[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
