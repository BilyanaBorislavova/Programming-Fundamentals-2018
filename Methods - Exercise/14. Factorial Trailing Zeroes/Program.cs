using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));
        }

        static BigInteger Factorial(BigInteger num)
        {
            BigInteger result = num;

            for (int i = 1; i < num; i++)
            {
                result *= i;
            }

            int zeroesCounter = 0;

            while (result % 10 == 0)
            {
                zeroesCounter++;
                result /= 10;
            }

            return zeroesCounter;

        }



    }
}
