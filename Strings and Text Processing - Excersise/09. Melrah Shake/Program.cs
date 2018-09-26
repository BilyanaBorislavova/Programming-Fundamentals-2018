using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int firstMatchIndex = input.IndexOf(pattern);
                int lastMatchIndex = input.LastIndexOf(pattern);

                if (firstMatchIndex != lastMatchIndex)
                {
                    Console.WriteLine("Shaked it.");

                    input = input.Remove(lastMatchIndex, pattern.Length);
                    input = input.Remove(firstMatchIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);

                }
                else
                {

                    break;
                }

            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
