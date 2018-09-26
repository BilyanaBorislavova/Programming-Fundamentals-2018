using System;

namespace _03._Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = (width * height) / 1000000;
            double resolution = Math.Round(result, 1);

            Console.WriteLine($"{width}x{height} => {resolution}MP");
        }
    }
}
