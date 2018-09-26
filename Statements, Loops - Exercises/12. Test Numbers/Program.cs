using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundry = int.Parse(Console.ReadLine());

            int number = 0;
            int sum = 0;
            int combinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    number = i * j;
                    sum += number * 3;
                    combinations++;
                    if (sum >= boundry)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundry}");
                        return;
                    }

                }
            }

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    number = i * j;

                    if (boundry >= sum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum}");
                        return;
                    }

                    sum += number * 3;
                    combinations++;

                }
            }


        }
    }
}
