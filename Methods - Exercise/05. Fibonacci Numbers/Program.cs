using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Fibonacci(num);
        }

        static void Fibonacci(int num)
        {
            int a = 1;
            int b = 1;

            for (int currentRotation = 0; currentRotation < num; currentRotation++)
            {
                int newB = a + b;
                a = b;
                b = newB;
            }

            Console.WriteLine(a);
        }
    }
}
