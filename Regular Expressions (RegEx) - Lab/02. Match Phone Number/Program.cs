using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phonePattern = @"(\+359)(\s{1})[2](\s{1})([0-9]{3})(\s{1})([0-9]{4})\b|(\+359)(\-{1})[2](\-{1})([0-9]{3})(\-{1})([0-9]{4})\b";

            Regex regex = new Regex(phonePattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            List<string> validPhones = new List<string>();

            foreach (Match item in matches)
            {
                validPhones.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", validPhones));

        }
    }
}
