using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrOne = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            char[] arrTwo = Console.ReadLine()
               .Split()
               .Select(char.Parse)
               .ToArray();

            bool orderByLetters = false;
            int count = 0;

            for (int i = 0; i < Math.Min(arrOne.Length - 1, arrTwo.Length - 1); i++)
            {
                if(arrOne[count] == arrTwo[count])
                {
                    while(arrOne[count] != arrTwo[count])
                    {
                        count++;
                    }
                }

                if(arrOne[count] > arrTwo[count])
                {
                    orderByLetters = true;
                }
                else
                {
                    orderByLetters = false;
                }

                if(arrOne[0] == arrTwo[0] && arrOne[1] == arrTwo[1] && arrOne.Length - 1 > arrTwo.Length - 1)
                {
                    orderByLetters = true;
                }
                
            }

            if (!orderByLetters)
            {
                Console.WriteLine(string.Join("", arrOne));
                Console.WriteLine(string.Join("", arrTwo));
            }
            else
            {
                Console.WriteLine(string.Join("", arrTwo));
                Console.WriteLine(string.Join("", arrOne));
            }

        }
    }
}
