using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SequenceOfCommands_broken
{
    public static void Main()
    {
        long sizeOfList = long.Parse(Console.ReadLine());

        List<long> nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        string[] commands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        while (commands[0] != "stop")
        {
            if (commands[0] == "multiply")
            {
                long index = long.Parse(commands[1]);
                long value = long.Parse(commands[2]);

                long num = nums.ElementAt((int)index - 1);
                long multiply = num * value;

                nums.RemoveAt((int)index - 1);
                nums.Insert((int)index - 1, multiply);

                Console.WriteLine(string.Join(" ", nums));
            }

            if(commands[0] == "add")
            {
                long index = long.Parse(commands[1]);
                long value = long.Parse(commands[2]);

                long number = nums.ElementAt((int)index - 1);
                long add = number + value;

                nums.RemoveAt((int)index - 1);
                nums.Insert((int)index - 1, add);

                Console.WriteLine(string.Join(" ", nums));
            }

            if(commands[0] == "subtract")
            {
                long index = long.Parse(commands[1]);
                long value = long.Parse(commands[2]);

                long num = nums.ElementAt((int)index - 1);
                long subtract = num - value;

                nums.RemoveAt((int)index - 1);
                nums.Insert((int)index - 1, subtract);

                Console.WriteLine(string.Join(" ", nums));
            }

            if(commands[0] == "rshift")
            {
                long lastElement = nums.ElementAt(nums.Count - 1);
                nums.RemoveAt(nums.Count - 1);
                nums.Insert(0, lastElement);

                Console.WriteLine(string.Join(" ", nums));
            }

            if(commands[0] == "lshift")
            {
                long firstElement = nums.ElementAt(0);
                nums.RemoveAt(0);
                nums.Insert(nums.Count, firstElement);

                Console.WriteLine(string.Join(" ", nums));
            }

            commands = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }
    }
}
