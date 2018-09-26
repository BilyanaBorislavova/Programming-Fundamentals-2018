using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var sum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                var num = arr[i];
                var num2 = arr[i + 1];
                sum += (num + num2);

            }
            if (arr.Length == 1)
            {
                Console.WriteLine(string.Join("", arr));
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
