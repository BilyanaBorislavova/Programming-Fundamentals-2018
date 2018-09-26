using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine($"{arr[0]}");
            }
            else
            {
                if(arr.Length % 2 == 0)
                {
                    int take = arr.Length / 2;
                    Console.WriteLine($"{arr[take - 1]}, {arr[take]}");
                }
                else
                {
                    int take = arr.Length / 2;
                    Console.WriteLine($"{arr[take - 1]}, {arr[take]}, {arr[take + 1]}");
                }
            }
        }
    }
}
