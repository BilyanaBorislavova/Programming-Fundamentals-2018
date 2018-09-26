using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int keys = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                letter += (char)keys;
                str.Append(letter);
            }

            Console.WriteLine(str);
        }
    }
}
