using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            var totalSum = 0;

            string firstStr = input[0];
            string secondStr = input[1];

            for (int i = 0; i < Math.Min(firstStr.Length, secondStr.Length); i++)
            {
                totalSum += firstStr[i] * secondStr[i];
            }

            for (int i = Math.Min(firstStr.Length, secondStr.Length); i < Math.Max(firstStr.Length, secondStr.Length); i++)
            {
                try
                {
                    totalSum += firstStr[i];
                }
                catch (Exception)
                {

                    totalSum += secondStr[i];
                }
            }


            Console.WriteLine(totalSum);
        }
    }
}
