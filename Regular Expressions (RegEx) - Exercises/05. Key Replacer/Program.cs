using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            string startPattern = @"\b(?<start>[a-zA-Z]+(\<|\||\\))\b";
            Regex startRegex = new Regex(startPattern);

            string endPattern = @"\b(?<end>(\<|\||\\)([a-zA-Z]+))\b";

            Match startMatch = startRegex.Match(key);
            Match end = Regex.Match(key, endPattern, RegexOptions.RightToLeft);

            string finalStart = startMatch.ToString().Remove(startMatch.Length - 1, 1);
            string finalEnd = end.ToString().Remove(0, 1);

            string finalPattern = $@"({finalStart}(.*?){finalEnd})";
            Regex finalRegex = new Regex(finalPattern);

            MatchCollection matches = finalRegex.Matches(text);

            StringBuilder str = new StringBuilder();

            foreach (Match match in matches)
            {
                var matchGroup = match.Groups[2];
                str.Append(matchGroup);
            }

            if (str.Length > 0)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Empty result");
            }


        }
    }
}
