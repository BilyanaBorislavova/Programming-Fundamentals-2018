using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long value = long.Parse(Console.ReadLine());
            long num = Math.Abs(value % 10);
            string number = string.Empty;
            Console.WriteLine(GetLastDigit(num, number));
        }

        static string GetLastDigit(long num, string number)
        {
           if(num == 1)
            {
                return number = "one";
            }
           else if(num == 2)
            {
                return number = "two";
            }
           else if(num == 3)
            {
                return number = "three";
            }
           else if(num == 4)
            {
                return number = "four";
            }
           else if(num == 5)
            {
                return number = "five";
            }
           else if(num == 6)
            {
                return number = "six";
            }
           else if(num == 7)
            {
                return number = "seven";
            }
           else if(num == 8)
            {
                return number = "eight";
            }
           else if(num == 9)
            {
                return number = "nine";
            }

            return number = "zero";
        }
    }
}
