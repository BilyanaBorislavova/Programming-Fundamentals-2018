using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();

            Dictionary<string, long> miners = new Dictionary<string, long>();

            long lines = 1;

            string resource = string.Empty;
            long quantity = 0;

            while (info != "stop")
            {
                if(lines % 2 == 1)
                {
                    resource = info;

                    if(!miners.ContainsKey(resource))
                    {
                        miners.Add(resource, 0);
                    }
                }
                else
                {
                    quantity = long.Parse(info);
                    if(miners.ContainsKey(resource))
                    {
                        miners[resource] += quantity;
                    }
                }

                lines++;

                info = Console.ReadLine();

            }

            foreach (var item in miners)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
