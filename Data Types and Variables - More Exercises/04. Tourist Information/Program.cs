using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string metricUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            if(metricUnit == "miles")
            {
                double km = value * 1.6;
                Console.WriteLine($"{value} miles = {km:f2} kilometers");
            }
            if(metricUnit == "inches")
            {
                double cm = value * 2.54;
                Console.WriteLine($"{value} inches = {cm:f2} centimeters");
            }
            if(metricUnit == "feet")
            {
                double cm = value * 30;
                Console.WriteLine($"{value} feet = {cm:f2} centimeters");
            }
            if(metricUnit == "yards")
            {
                double meters = value * 0.91;
                Console.WriteLine($"{value} yards = {meters:f2} meters");
            }
            if(metricUnit == "gallons")
            {
                double liters = value * 3.8;
                Console.WriteLine($"{value} gallons = {liters:f2} liters");
            }
        }
    }
}
