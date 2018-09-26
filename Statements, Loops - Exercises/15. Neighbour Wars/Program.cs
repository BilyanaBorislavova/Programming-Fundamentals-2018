using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int initialHealthPesho = 100;
            int initialHealthGosho = 100;

            int turns = 0;

            while (initialHealthPesho > 0 || initialHealthGosho > 0)
            {
                turns++;

                if(turns % 2 != 0)
                {
                    initialHealthGosho -= peshoDamage;

                    if(initialHealthGosho < 1)
                    {
                        Console.WriteLine($"Pesho won in {turns}th round.");
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {initialHealthGosho} health.");
                }
                else
                {
                    initialHealthPesho -= goshoDamage;

                    if(initialHealthPesho < 1)
                    {
                        Console.WriteLine($"Gosho won in {turns}th round.");
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {initialHealthPesho} health.");
                }

                if(turns % 3 == 0)
                {
                    initialHealthPesho += 10;
                    initialHealthGosho += 10;
                }
            }
        }
    }
}
