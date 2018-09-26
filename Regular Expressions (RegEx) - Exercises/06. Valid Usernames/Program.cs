using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(new char[] { ' ', '/', '\\', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string validUsernamesPattern = @"\b([A-Za-z])([a-zA-Z0-9_]){2,24}\b";
            Regex regex = new Regex(validUsernamesPattern);

            List<string> valid = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                Match matches = regex.Match(usernames[i]);

                if(matches.Success)
                {
                    valid.Add(usernames[i]);
                }

            }

            int largestSum = 0;
            int sum = 0;

            List<string> finalStrings = new List<string>();

            for (int i = 0; i < valid.Count - 1; i++)
            {
                sum = valid[i].Length + valid[i + 1].Length;
                
                if (largestSum < sum)
                {
                    finalStrings.Clear();
                    largestSum = sum;
                    finalStrings.Add(valid[i]);
                    finalStrings.Add(valid[i + 1]);
                }

            }

            Console.WriteLine(string.Join("\n", finalStrings));
        }
    }
}
