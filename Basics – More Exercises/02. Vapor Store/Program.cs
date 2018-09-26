using System;

namespace _02._Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpent = 0;

            string command = Console.ReadLine();

            double OutFall4 = 39.99;
            double CSOG = 15.99;
            double ZplinterZell = 19.99;
            double Honored2 = 59.99;
            double RoverWatch = 29.99;
            double RoverWatchOriginsEditions = 39.99;

            while (command != "Game Time")
            {
                if(command != "CS: OG" && command != "OutFall 4" && command != "Zplinter Zell" && command != "Honored 2" && command != "RoverWatch" && command != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }

                if(command == "OutFall 4")
                {
                    if (currentBalance >= OutFall4)
                    {
                        Console.WriteLine("Bought OutFall 4");
                        currentBalance -= OutFall4;
                        totalSpent += OutFall4;
                    }else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if(command == "CS: OG")
                {
                    if (currentBalance >= CSOG)
                    {
                        Console.WriteLine("Bought CS: OG");
                        currentBalance -= CSOG;
                        totalSpent += CSOG;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if(command == "Zplinter Zell")
                {
                    if (currentBalance >= ZplinterZell)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        currentBalance -= ZplinterZell;
                        totalSpent += ZplinterZell;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if(command == "Honored 2")
                {
                    if (currentBalance >= Honored2)
                    {
                        Console.WriteLine("Bought Honored 2");
                        currentBalance -= Honored2;
                        totalSpent += Honored2;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if(command == "RoverWatch")
                {
                    if (currentBalance >= RoverWatch)
                    {
                        Console.WriteLine("Bought RoverWatch");
                        currentBalance -= RoverWatch;
                        totalSpent += RoverWatch;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if(command == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= RoverWatchOriginsEditions)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        currentBalance -= RoverWatchOriginsEditions;
                        totalSpent += RoverWatchOriginsEditions;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if(currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                }

                command = Console.ReadLine();
            }

            if(currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
