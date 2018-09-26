using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();

                if(word == "even")
                {
                   if(i % 2 == 0)
                    {
                        str.Append(text);
                        str.Append(delimeter);
                    }
                }

                if(word == "odd")
                {
                    if(i % 2 != 0)
                    {
                        str.Append(text);
                        str.Append(delimeter);
                    }
                }
            }

            str = str.Remove(str.Length - 1, 1);
            Console.WriteLine(str);
           
        }
    }
}
