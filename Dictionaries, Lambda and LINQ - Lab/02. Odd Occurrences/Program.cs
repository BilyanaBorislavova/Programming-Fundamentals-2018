using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> oddWordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if(!oddWordsCount.ContainsKey(word))
                {
                    oddWordsCount.Add(word, 1);
                }
                else
                {
                    oddWordsCount[word]++;
                }
            }

            List<string> validWords = new List<string>();
            
            foreach (var eachWord in oddWordsCount.Where(s => s.Value % 2 != 0))
            {
                validWords.Add(eachWord.Key);
            }

            Console.WriteLine(string.Join(", ", validWords));
        }
    }
}
