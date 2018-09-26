using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z]{1})([a-z]+) ([A-Z]{1})([a-z]+)\b";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (Match name in matches)
            {
                Console.Write(name + " ");
            }
        }
    }
}
