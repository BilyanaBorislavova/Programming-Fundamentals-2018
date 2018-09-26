using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                str.Append(letter);
            }

            Console.WriteLine($"The word is: {str}");
        }
    }
}
