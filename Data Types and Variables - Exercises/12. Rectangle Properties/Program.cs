using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;
            decimal diagonalOne = (decimal)Math.Pow(width, 2);
            decimal diagonalTwo = (decimal)Math.Pow(height, 2);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(Math.Sqrt((double)diagonalOne + (double)diagonalTwo));

        }
    }
}
