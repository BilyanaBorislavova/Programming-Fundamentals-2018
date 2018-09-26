using System;

namespace _01._X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int whiteSpacesMiddle = n - 2;
            int whiteSpaces = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', whiteSpaces), new string(' ', whiteSpacesMiddle));
                whiteSpacesMiddle -= 2;
                whiteSpaces++;
            }

            Console.WriteLine("{0}x{0}", new string(' ', whiteSpaces));

            int whiteSpacesMiddleTwo = 1;
            int whiteSpacesNew = n / 2 - 1;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', whiteSpacesNew), new string(' ', whiteSpacesMiddleTwo));
                whiteSpacesMiddleTwo += 2;
                whiteSpacesNew--;
            }

        }
    }
}
