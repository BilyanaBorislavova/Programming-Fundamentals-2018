using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> isPalindrome = new List<string>();

            foreach (var word in words)
            {
                var reversedWord = word.Reverse().ToList();

                if(!word.Equals(reversedWord))
                {
                    isPalindrome.Add(reversedWord.ToString());
                }
                
            }

            Console.WriteLine(string.Join("", isPalindrome));
        }
    }
}
