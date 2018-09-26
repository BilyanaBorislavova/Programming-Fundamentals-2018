using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte century = byte.Parse(Console.ReadLine());

            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long miliseconds = (long)seconds * 1000;
            long microseconds = (long)miliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
