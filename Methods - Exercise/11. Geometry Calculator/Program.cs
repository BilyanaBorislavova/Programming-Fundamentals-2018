using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if(figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetTriangleArea(side, height):f2}");
            }
            else if(figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetSquareArea(side):f2}");
            }
            else if(figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetRectangleArea(width, height):f2}");
            }
            else if(figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetCircleArea(radius):f2}");
            }
        }

        static double GetTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        static double GetSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
