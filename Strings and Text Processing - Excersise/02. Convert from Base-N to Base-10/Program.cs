using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string baseNumber = input[0];
            int number = int.Parse(input[1]);

            Console.WriteLine(Convert.ToInt32("110", number));
        }
    }
}
