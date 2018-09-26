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

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (info[0] != "END")
            {
                if (info[0] == "A")
                {
                    string name = info[1];
                    string phone = info[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }
                    else
                    {
                        phonebook[name] = phone;
                    }
                }

                if (info[0] == "S")
                {
                    string name = info[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                if(info[0] == "ListAll")
                {
                    foreach (var namePhone in phonebook)
                    {
                        Console.WriteLine($"{namePhone.Key} -> {namePhone.Value}");
                    }
                }

                info = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
