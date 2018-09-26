using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCounts = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double mastersuitePrice = 0;

            if(month == "May" || month == "October")
            {
                if(nightCounts > 7)
                {
                    studioPrice = (50 * nightCounts) - ((50 * nightCounts) * 0.05);
                }
                else
                {
                    studioPrice = 50 * nightCounts;
                }

                doublePrice = 65 * nightCounts;
                mastersuitePrice = 75 * nightCounts;
            }

            else if(month == "June" || month == "September")
            {
                if(nightCounts > 14)
                {
                    doublePrice = (72 * nightCounts) - ((72 * nightCounts) * 0.1);
                }
                else
                {
                    doublePrice = 72 * nightCounts;
                }

                studioPrice = 60 * nightCounts;
                mastersuitePrice = 82 * nightCounts;
            }
            else if(month == "July" || month == "August" || month == "December")
            {
                if(nightCounts > 14)
                {
                    mastersuitePrice = (89 * nightCounts) - ((89 * nightCounts) * 0.15);
                }
                else
                {
                    mastersuitePrice = 89 * nightCounts;
                }

                studioPrice = 68 * nightCounts;
                doublePrice = 77 * nightCounts;
            }

            if(month == "September" && nightCounts > 7)
            {
                studioPrice = (60 * nightCounts) - 60;
            }
            else if(month == "October" && nightCounts > 7)
            {
                double price = ((50 * nightCounts) - 50);
                studioPrice = price - (price * 0.05);
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {mastersuitePrice:f2} lv.");
        }
    }
}
