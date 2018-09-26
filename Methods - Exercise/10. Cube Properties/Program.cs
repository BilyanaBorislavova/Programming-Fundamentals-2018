using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if(parameter == "face")
            {
                Console.WriteLine($"{GetCubeFace(cubeSide):f2}");
            }
            else if(parameter == "space")
            {
                Console.WriteLine($"{GetCubeSpace(cubeSide):f2}");
            }
            else if(parameter == "volume")
            {
                Console.WriteLine($"{GetCubeVolume(cubeSide):f2}");
            }
            else if(parameter == "area")
            {
                Console.WriteLine($"{GetCubeArea(cubeSide):f2}");
            }

        }

        static double GetCubeFace(double cubeSide)
        {
            return Math.Sqrt(2) * cubeSide;
        }

        static double GetCubeSpace(double cubeSide)
        {
            return Math.Sqrt(3) * cubeSide;
        }

        static double GetCubeVolume(double cubeSide)
        {
            return Math.Pow(cubeSide, 3);
        }

        static double GetCubeArea(double cubeSide)
        {
            return 6 * Math.Pow(cubeSide, 2);
        }
    }
}
