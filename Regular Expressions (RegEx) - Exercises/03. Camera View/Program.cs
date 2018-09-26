using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();

            string pattern = @"(\|<)";
            Regex regex = new Regex(pattern);

            int elementsToskip = numbers[0];
            int elementsToTake = numbers[1];

            MatchCollection matches = regex.Matches(text);

            List<int> indexes = new List<int>();

            foreach (Match item in matches)
            {
                indexes.Add(item.Index);
            }

            List<string> strings = new List<string>();
            foreach (var index in indexes)
            {
                var str = text.Substring(index + 2);
                strings.Add(str);
            }

            foreach (var item in strings)
            {
                var sentence = item;

                if (item.Contains("|<"))
                {
                    int index = item.IndexOf("|<");
                    sentence = item.Remove(index);
                    Console.Write(string.Join("", sentence.Skip(elementsToskip).Take(elementsToTake)) + ", ");
                }
                else
                {
                    Console.Write(string.Join("", sentence.Skip(elementsToskip).Take(elementsToTake)));
                }
            }
        }
    }
}
