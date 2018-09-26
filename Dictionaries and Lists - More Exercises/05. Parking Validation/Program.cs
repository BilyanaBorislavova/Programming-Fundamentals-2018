using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^([A-Z]{2})([0-9]{4})([A-Z]{2})$";
            Regex regex = new Regex(pattern);

            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = data[0];

                if (data.Length == 3)
                {
                    string name = data[1];
                    string license = data[2];

                    Match match = regex.Match(license);

                    if (command == "register")
                    {
                        if (match.Success)
                        {
                            if (!dict.ContainsKey(name) && !dict.ContainsValue(license))
                            {
                                dict.Add(name, license);
                                Console.WriteLine($"{name} registered {license} successfully");
                            }
                            else if (dict.ContainsValue(license))
                            {
                                Console.WriteLine($"ERROR: license plate {license} is busy");
                            }
                            else
                            {
                                dict[name] = license;
                                Console.WriteLine($"{name} registered {license} successfully");
                            }

                            if (!dict.ContainsValue(license) && dict.ContainsKey(name))
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {license}");
                            }


                        }

                        if (!match.Success)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {license}");
                        }
                    }
                }
                else
                {
                    string name = data[1];

                    if (command == "unregister")
                    {
                        if (dict.ContainsKey(name))
                        {
                            Console.WriteLine($"user {name} unregistered successfully");
                            dict.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
