using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char a = firstLetter; a <= secondLetter; a++)
            {
                for (char b = firstLetter; b <= secondLetter; b++)
                {
                    for (char c = firstLetter; c <= secondLetter; c++)
                    {
                        if(a != thirdLetter && b != thirdLetter && c != thirdLetter)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
