using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s([a-z0-9]+[\.\-_]?[a-z0-9]+)@([a-z]+[-]?[a-z]+[\.][a-z]+[\.]?[a-z]+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);


            foreach (Match item in matches)
            { 
                Console.WriteLine(item.Value.Remove(0, 1));
            }

        }
    }
}
