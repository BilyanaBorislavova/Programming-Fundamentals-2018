using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> logsAggregator = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string IP = data[0];
                string user = data[1];
                int duration = int.Parse(data[2]);

                if(!logsAggregator.ContainsKey(user))
                {
                    logsAggregator.Add(user, new Dictionary<string, int>());
                }
                if (!logsAggregator[user].ContainsKey(IP))
                {
                    logsAggregator[user].Add(IP, duration);
                }
                else
                {
                    logsAggregator[user][IP] += duration;
                }

            }

            foreach (var log in logsAggregator.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{log.Key}: {string.Join(" ", log.Value.Values.Sum())} [{string.Join(", ", log.Value.Keys.OrderBy(a => a))}]");
            }
        }
    }
}
