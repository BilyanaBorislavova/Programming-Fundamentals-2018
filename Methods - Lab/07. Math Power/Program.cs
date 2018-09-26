using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{MathPower(num1, num2)}");
        }

        static double MathPower(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
