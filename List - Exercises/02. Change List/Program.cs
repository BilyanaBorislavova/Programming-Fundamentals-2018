using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (true)
            {
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    nums.RemoveAll(a => a == element);
                }

                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    nums.Insert(position, element);
                }

                if(command[0] == "Odd")
                {
                    nums.RemoveAll(a => a % 2 == 0);
                    break;
                }
                
                if(command[0] == "Even")
                {
                    nums.RemoveAll(a => a % 2 != 0);
                    break;
                }

                command = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
