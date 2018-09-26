using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();

            Dictionary<string, string> nameEmail = new Dictionary<string, string>();

            int lines = 0;

            string name = string.Empty;
            string email = string.Empty;

            while (info != "stop")
            {
                if(lines % 2 == 0)
                {
                    name = info;

                    if(!nameEmail.ContainsKey(name))
                    {
                        nameEmail.Add(name, string.Empty);
                    }
                }
                else
                {
                    email = info;

                    if(email.EndsWith("uk") || email.EndsWith("us"))
                    {
                        nameEmail.Remove(name);
                    }
                    else
                    {
                        nameEmail[name] = email;
                    }
                }

                lines++;
                info = Console.ReadLine();
            }

            foreach (var item in nameEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
