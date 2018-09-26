using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int baseNumber = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            string conversion = "";


            while (number != 0)
            {

                conversion += Convert.ToString(number % baseNumber);
                number = number / baseNumber;
            }
            var conversion2 = conversion.ToArray().Reverse();
            Console.WriteLine(string.Join("", conversion2));

        }
    }
}
