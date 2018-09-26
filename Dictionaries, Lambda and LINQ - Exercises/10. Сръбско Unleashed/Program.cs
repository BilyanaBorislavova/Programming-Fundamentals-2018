using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();

            string pattern = @"([A-Za-z ]+) @([A-Za-z ]+) ([0-9]+) ([0-9]+)";
            Regex regex = new Regex(pattern);

            List<string> validInput = new List<string>();

            Dictionary<string, Dictionary<string, decimal>> data = new Dictionary<string, Dictionary<string, decimal>>();

            while (info != "End")
            {
                Match match = regex.Match(info);

                if (match.Success)
                {
                    validInput.Add(info);
                }

                info = Console.ReadLine();
            }

            foreach (var sentence in validInput)
            {
                string[] tokens = sentence.Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);

                int index = sentence.IndexOf('@');
                string name = tokens[0];

                string[] split = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var leftInput = sentence.Skip(index + 1).ToList();
                StringBuilder location = new StringBuilder();
                StringBuilder finalInput = new StringBuilder();

                for (int i = 0; i < leftInput.Count; i++)
                {

                    if (Char.IsLetter(leftInput[i]) || Char.IsWhiteSpace(leftInput[i]))
                    {
                        location.Append(leftInput[i]);
                    }

                }

                string venue = location.ToString();

                leftInput = sentence.Skip(index + location.Length).ToList();

                for (int i = 0; i < leftInput.Count; i++)
                {
                    finalInput.Append(leftInput[i]);
                }

                string[] newSplit = finalInput.ToString().Split();

                long ticketPrice = long.Parse(newSplit[0]);
                decimal ticketsCount = decimal.Parse(newSplit[1]);

                decimal totalSum = 0;
                totalSum = ticketPrice * ticketsCount;

                if(!data.ContainsKey(venue))
                {
                    data.Add(venue, new Dictionary<string, decimal>());
                }

                if(!data[venue].ContainsKey(name))
                {
                    data[venue].Add(name, totalSum);
                }
                else
                {
                    data[venue][name] += totalSum;
                }

            }


            foreach (var venue in data)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }

        }
    }
}
