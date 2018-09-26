using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatChar = char.Parse(Console.ReadLine());
            char secondBoatChar = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int firstBoat = 0;
            int secondBoat = 0;

            for (int i = 1; i <= n; i++)
            {
                string random = Console.ReadLine();

                if (random == "UPGRADE")
                {
                    firstBoatChar += (char)3;
                    secondBoatChar += (char)3;
                }

                else if (i % 2 == 0)
                {
                    secondBoat += random.Length;
                }
                else
                {
                    firstBoat += random.Length;
                }

                if(firstBoat >= 50 || secondBoat >= 50)
                 break;

            }

            if (firstBoat > secondBoat)
            {
                Console.WriteLine(firstBoatChar);
            }
            else
            {
                Console.WriteLine(secondBoatChar);
            }


        }
    }
}
