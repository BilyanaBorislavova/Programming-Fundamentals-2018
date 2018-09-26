using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;

            int combinations = 0;
            for (i = n; i <= m; i++)
            {
                for (j = m; j >= n; j--)
                {
                    combinations++;

                    if(i + j == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNumber}");
                        return;
                    }

                }
            }

            if (i + j == magicNumber)
            {
                Console.WriteLine($"{j} + {i} = {magicNumber}");
               
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
