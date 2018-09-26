using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ",PrimesInGivenRange(startNum, endNum)));
        }

        static List<int> PrimesInGivenRange(int startNum, int endNum)
        {
            List<int> nums = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                if(i < 2)
                {
                    isPrime = false;
                }

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    nums.Add(i);
                }

            }

            return nums;
        }
    }
}
