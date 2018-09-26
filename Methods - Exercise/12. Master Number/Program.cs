using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsDivisibleBy7(i) && ContainsEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigitsDivisibleBy7(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        static bool ContainsEvenDigits(int n)
        {
            var digit = 0;

            while (n > 0)
            {
                digit = n % 10;
                n /= 10;

                if (digit % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }


        static bool IsPalindrome(int n)
        {
            string number = n.ToString();
            string reversedNumber = new string(number.Reverse().ToArray());

            if (number == reversedNumber)
            {
                return true;
            }

            return false;
        }

    }
}
