using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = Console.ReadLine();

            if(variable == "True")
            {
                Console.WriteLine("Yes");
            }
            else if(variable == "False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
