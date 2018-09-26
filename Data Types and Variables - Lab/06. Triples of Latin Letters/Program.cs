using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        char first = (char)('a' + a);
                        char second = (char)('a' + b);
                        char third = (char)('a' + c);
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
            
        }
    }
}
