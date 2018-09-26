using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int waterTankCapacity = 255;

            for (int i = 0; i < lines; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());

                if(waterQuantity > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTankCapacity -= waterQuantity;
                }

            }
            Console.WriteLine(255 - waterTankCapacity);
        }
    }
}
