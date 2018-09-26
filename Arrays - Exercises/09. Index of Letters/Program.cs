using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabeth ={ "a" ,"b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabeth.Length; j++)
                {
                    if(text[i].ToString().Contains(alphabeth[j]))
                    {
                        Console.WriteLine($"{text[i]} -> {j}");
                    }
                }
            }
        }
    }
}
