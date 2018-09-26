using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int maxCount = 1;
            int maxValue = 0;
            int position = 0;

            while (position < n.Count - 1)
            {
                if(n[position] == n[position + 1])
                {
                    counter++;

                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        maxValue = n[position];
                    }
                }
                else
                {
                    counter = 1;
                }
                
                position++;
            }

            if (n.Count == 1)
            {
                Console.WriteLine(string.Join(" ", n));
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(maxValue + " ");
                }
            }
        }
    }
}
