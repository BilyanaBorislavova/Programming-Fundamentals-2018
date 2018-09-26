using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            ReversedOrder(value);
        }

        static void ReversedOrder(string value)
        {
            var reversedValue = value.Reverse();
            Console.WriteLine(string.Join("", reversedValue));
        }
       
    }
}
