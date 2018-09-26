using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int gropuSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;
            double pricePerPerson = 0;

            if(gropuSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else if(gropuSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                
                if(package == "Normal")
                {
                    totalPrice = 2500 + 500;
                    discount = totalPrice - (0.05 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if(package == "Gold")
                {
                    totalPrice = 2500 + 750;
                    discount = totalPrice - (0.1 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if(package == "Platinum")
                {
                    totalPrice = 2500 + 1000;
                    discount = totalPrice - (0.15 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if(gropuSize > 50 && gropuSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");

                if (package == "Normal")
                {
                    totalPrice = 5000 + 500;
                    discount = totalPrice - (0.05 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = 5000 + 750;
                    discount = totalPrice - (0.1 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = 5000 + 1000;
                    discount = totalPrice - (0.15 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if(gropuSize > 100 && gropuSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");

                if (package == "Normal")
                {
                    totalPrice = 7500 + 500;
                    discount = totalPrice - (0.05 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Gold")
                {
                    totalPrice = 7500 + 750;
                    discount = totalPrice - (0.1 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "Platinum")
                {
                    totalPrice = 7500 + 1000;
                    discount = totalPrice - (0.15 * totalPrice);
                    pricePerPerson = discount / gropuSize;

                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
        }
    }
}
