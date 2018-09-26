using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int j = 0; j < numbers.Count; j++)
            {
                if(numbers[j] > 0)
                {
                    Console.WriteLine($"{numbers[j]} ");
                }
                else
                {
                   
                }
            }
        }
    }
}