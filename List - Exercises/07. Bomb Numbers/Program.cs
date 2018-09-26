using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialNumber = input[0];
            int power = input[1];

            while (numbers.Contains(specialNumber))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] == specialNumber)
                    {
                        int numIndex = i;

                        int frontNumber = numIndex - power;

                        if(frontNumber < 0)
                        {
                            frontNumber = 0;
                        }

                        int backNumber = numIndex + power;

                        if(backNumber >= numbers.Count)
                        {
                            backNumber = numbers.Count - 1;
                        }

                        for (int j = frontNumber; j <= backNumber; j++)
                        {
                            numbers.RemoveAt(frontNumber);
                        }
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
