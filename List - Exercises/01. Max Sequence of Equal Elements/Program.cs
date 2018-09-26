using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int maxCounter = 1;
            int maxValue = 1;
            int position = 0;

            while (position < numbers.Count - 1)
            {
                if(numbers[position] == numbers[position + 1])
                {
                    counter++;

                    if(counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxValue = numbers[position];
                    }
                }
                else
                {
                    counter = 1;
                }

                position++;
            }

            if (numbers.Count == 1)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < maxCounter; i++)
                {
                    Console.Write(maxValue + " ");
                }
            }
        }
    }
}
