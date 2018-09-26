using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string digits = @"([0-9]+)";
            Regex regex = new Regex(digits);
            decimal totalSum = 0;

            foreach (var item in input)
            {
                Match digitMatch = regex.Match(item);
                char firstLetter = item[0];
                decimal digit = decimal.Parse(digitMatch.Value);
                char lastLetter = item.ElementAt(item.Length - 1);

                int indexOfFirstLetter = (int)firstLetter % 32;
                int indexOfSecondLetter = (int)lastLetter % 32; 

                if(Char.IsUpper(firstLetter))
                {
                    totalSum += digit / indexOfFirstLetter;
                }
                else
                {
                    totalSum += digit * indexOfFirstLetter;
                }

                if(Char.IsUpper(lastLetter))
                {
                    totalSum -= indexOfSecondLetter;
                }
                else
                {
                    totalSum += indexOfSecondLetter;
                }

            }

           Console.WriteLine($"{totalSum:f2}");                
                 
        }
    }
}
