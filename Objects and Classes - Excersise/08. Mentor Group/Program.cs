using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            List<DateTime> formattedDates = new List<DateTime>();

            Dictionary<string, Dictionary<List<DateTime>, List<string>>> dict = new Dictionary<string, Dictionary<List<DateTime>, List<string>>>();
            string name = string.Empty;

            while (data != "end of dates")
            {
                string[] tokens = data
               .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

                name = tokens[0];

                for (int i = 1; i < tokens.Length; i++)
                {
                    var ddmmyyyy = (DateTime.ParseExact(tokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    formattedDates.Add(ddmmyyyy);
                }

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<List<DateTime>, List<string>>());
                }


                if (!dict[name].ContainsKey(formattedDates))
                {
                    dict[name].Add(formattedDates.ToList(), new List<string>());
                }

                formattedDates.Clear();
                data = Console.ReadLine();
            }

            while (data != "end of comments")
            {
                string[] tokens = data
                               .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();

                name = tokens[0];
                var comments = tokens.Skip(1).Take(tokens.Length).ToList();

                if (dict.ContainsKey(name))
                {
                    dict[name].Add(new List<DateTime>(), comments.ToList());
                }

                data = Console.ReadLine();
            }

            foreach (var person in dict.OrderBy(a => a.Key))
            {
                Console.WriteLine(person.Key);
                Console.WriteLine("Comments:");

                foreach (var comment in person.Value.Values.Where(a => a.Count > 0))
                {
                    Console.WriteLine($"- {string.Join("\n- ", comment)}");
                }

                Console.WriteLine($"Dates attended:");
                foreach (var item in person.Value)
                {
                    foreach (var date in item.Key.OrderBy(a => a))
                    {
                        Console.WriteLine($"-- {date.Day}/{date.Month:d2}/{date.Year}");
                    }
                }
            }

        }
    }
}
