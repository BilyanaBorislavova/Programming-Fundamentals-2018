using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMetres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalTime = (hours * 3600) + (minutes * 60) + seconds;

            float milesPerSecond = (float)distanceInMetres / totalTime;
            float kmPerHour = ((float)distanceInMetres / 1000) / ((float)totalTime / 3600);
            float metresToMiles = ((float)distanceInMetres / 1609) / ((float)totalTime / 3600);
            Console.WriteLine($"{milesPerSecond:0.#######}");
            Console.WriteLine($"{kmPerHour:0.#######}");
            Console.WriteLine($"{metresToMiles:0.#######}");
        }
    }
}
