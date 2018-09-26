using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();

            int decimalF = Convert.ToInt32(hexNumber, 16);
            Console.WriteLine(decimalF);
        }
    }
}
