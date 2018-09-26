using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pics = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            double goodPicsPercent = double.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double numOfGoodPics = Math.Ceiling((goodPicsPercent / 100) * pics);
            long seconds = pics * filterTime;
            long filteredPicsSeconds = (long)numOfGoodPics * uploadTime;
            long totalTimeInSeconds = seconds + filteredPicsSeconds;

            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);

            Console.WriteLine($"{time.Days}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");

        }
    }
}
