using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            string firstStr = input[0];
            string secondStr = input[1];

            int one = firstStr.ToCharArray().Distinct().Count();
            int two = secondStr.ToCharArray().Distinct().Count();

            if(one == two)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

    }
}
