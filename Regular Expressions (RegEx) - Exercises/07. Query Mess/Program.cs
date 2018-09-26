using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] splitSeries = input.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                string[] splitFields = input.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                input = Console.ReadLine();
            }
        }
    }
}
