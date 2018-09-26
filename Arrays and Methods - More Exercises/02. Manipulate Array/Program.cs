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

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if(commands[0] == "Reverse")
                {
                    myList.Reverse();
                }

                if(commands[0] == "Distinct")
                {
                    myList = myList.Distinct().ToList();
                }

                if(commands[0] == "Replace")
                {
                    int index = int.Parse(commands[1]);
                    string replacement = commands[2];

                    var elementAt = myList.ElementAt(index);
                    myList.RemoveAt(index);
                    myList.Insert(index, replacement);

                }
            }

            Console.WriteLine($"{string.Join(", ", myList)}");
        }

    }
}
