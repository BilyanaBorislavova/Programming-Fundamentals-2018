using System;

namespace _05._BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = Math.Round(numberOfBeats / 4, 1);

            double seconds = Math.Floor(numberOfBeats * 60 / beatsPerMinute);

            if(seconds >= 60)
            {
                double minutes = seconds / 60;
                seconds -= minutes * 60;

                Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
            }
            else
            {
                Console.WriteLine($"{bars} bars - 0m {seconds}s");
            }

            

           
        }
    }
}
