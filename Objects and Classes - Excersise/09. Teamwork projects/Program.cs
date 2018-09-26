using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeamsToRegister = int.Parse(Console.ReadLine());

            Dictionary<string, string> clubs = new Dictionary<string, string>();

            for (int i = 0; i < countOfTeamsToRegister; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creator = data[0];
                string team = data[1];

                if(!clubs.ContainsKey(team) && !clubs.ContainsValue(creator))
                {
                    clubs.Add(team, creator);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
                else if(clubs.ContainsKey(team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if(clubs.ContainsValue(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

            }

            string[] info = Console.ReadLine()
                    .Split(new string[] {"->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            List<string> ppl = new List<string>();
            
            while (info[0] != "end of assignment")
            {
                string member = info[0];
                string team = info[1];

                if(!clubs.ContainsKey(team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if(clubs.ContainsValue(member) || ppl.Contains(member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                }
                else if(!ppl.Contains(member))
                {
                    clubs[team] += " " + member;
                    ppl.Add(member);
                }


                info = Console.ReadLine()
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            }

            foreach (var item in clubs.Where(a => a.Value.Split().Count() > 1).OrderByDescending(a => a.Value.Split().Count()).ThenBy(a => a.Key))
            {
                var firstValue = item.Value.Split().First();
                var allValues = item.Value.Split().Skip(1);

                Console.WriteLine(item.Key);
                Console.WriteLine($"- {string.Join("\n", firstValue)}");
                Console.WriteLine($"-- {string.Join("\n-- ", allValues.OrderBy(a => a))}");
            }


            Console.WriteLine("Teams to disband:");

            foreach (var item in clubs.Where(a => a.Value.Split().Count() == 1).OrderBy(a => a.Key))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}