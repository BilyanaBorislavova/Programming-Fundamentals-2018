using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (info[0] != "END")
            {
                if(info[0] == "A")
                {
                    string name = info[1];
                    string phone = info[2];

                    if(!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }
                    else
                    {
                        phonebook[name] = phone;
                    }
                }

                if(info[0] == "S")
                {
                    string name = info[1];

                    if(phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                info = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
