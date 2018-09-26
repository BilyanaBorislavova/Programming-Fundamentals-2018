using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = words.Where(a => a.Length < 5).OrderBy(a => a).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
