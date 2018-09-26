using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arrTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int startCount = 0;
            int endCount = 0;

            for (int i = 0; i < Math.Min(arrOne.Length, arrTwo.Length); i++)
            {
                if(arrOne[i] == arrTwo[i])
                {
                    startCount++;
                }

                if (arrOne[arrOne.Length - i - 1] == arrTwo[arrTwo.Length - i - 1])
                {
                    endCount++;
                }

            }

            if(startCount > endCount)
            {
                Console.WriteLine(startCount);
            }
            else
            {
                Console.WriteLine(endCount);
            }
        }
    }
}
