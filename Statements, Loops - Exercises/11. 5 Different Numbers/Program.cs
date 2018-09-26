using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if(numTwo - numOne < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = numOne; n1 <= numTwo; n1++)
                {
                    for (int n2 = numOne; n2 <= numTwo; n2++)
                    {
                        for (int n3 = numOne; n3 <= numTwo; n3++)
                        {
                            for (int n4 = numOne; n4 <= numTwo; n4++)
                            {
                                for (int n5 = numOne; n5 <= numTwo; n5++)
                                {
                                    if(numOne <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= numTwo)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
