using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while(commands[0] != "END")
            {
                
                if (commands[0] == "Reverse")
                {
                    myList.Reverse();
                }

                if (commands[0] == "Distinct")
                {
                    myList = myList.Distinct().ToList();
                }

                if (commands[0] == "Replace")
                {
                    int index = int.Parse(commands[1]);
                    string replacement = commands[2];

                    if (index >= myList.Count || index < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        var elementAt = myList.ElementAt(index);
                        myList.RemoveAt(index);
                        myList.Insert(index, replacement);
                    }
                }

                if(commands[0] != "Reverse" && commands[0] != "Distinct" && commands[0] != "Replace")
                {
                    Console.WriteLine("Invalid input!");
                }

                commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine($"{string.Join(", ", myList)}");
        }

    }
}
