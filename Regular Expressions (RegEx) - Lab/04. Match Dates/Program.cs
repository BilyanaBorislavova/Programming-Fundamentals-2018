using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();

            string datePattern = @"\b(?<date>[0-9]{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            MatchCollection dateMatch = Regex.Matches(dates, datePattern);

            foreach (Match date in dateMatch)
            {
                Console.WriteLine($"Day: {date.Groups["date"].Value}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }

            
        }
    }
}
