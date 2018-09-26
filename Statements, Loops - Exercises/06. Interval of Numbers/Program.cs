using System;

namespace _06._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (startNum < endNum)
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = endNum; i <= startNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
