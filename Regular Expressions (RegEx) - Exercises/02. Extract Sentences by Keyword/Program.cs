using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] text = Console.ReadLine()
                .Split(new char[] { '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = $@"\b{word}\b";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < text.Length; i++)
            {
                Match match = regex.Match(text[i]);

                if(match.Success)
                {
                    if (text[i].StartsWith(" "))
                    {
                        Console.WriteLine(text[i].Remove(0, 1));
                    }
                    else
                    {
                        Console.WriteLine(text[i]);
                    }
                }
            }
        }
    }
}
