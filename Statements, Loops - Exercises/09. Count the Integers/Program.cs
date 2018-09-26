using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    count++;
                }
                catch 
                {
                    break;
                }
            }

            Console.WriteLine(count);
            
        }
    }
}
