using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (data[0] != "end")
            {
                string ip = data[0].Remove(0, 3);
                string user = data[2].Remove(0, 5);

                if(!dict.ContainsKey(user))
                {
                    dict.Add(user, new Dictionary<string, int>());
                }

                if (!dict[user].ContainsKey(ip))
                {
                    dict[user].Add(ip, 1);
                }
                else
                {
                    dict[user][ip]++;
                }


                data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var user in dict.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{user.Key}: ");

                List<string> values = new List<string>();

                foreach (var IP in user.Value)
                {
                    values.Add($"{IP.Key} => {IP.Value}");
                }

                Console.WriteLine(string.Join(", ", values) + ".");
                values.Clear();
            }
        }
    }
}
