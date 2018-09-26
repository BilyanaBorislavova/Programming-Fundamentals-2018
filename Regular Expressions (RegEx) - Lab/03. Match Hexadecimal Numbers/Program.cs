using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([0]?[x]?)([0-9]+)?([A-F]+)?\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
