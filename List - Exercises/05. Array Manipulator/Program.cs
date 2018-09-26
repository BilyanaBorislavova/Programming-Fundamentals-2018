using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
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



            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);

                    nums.Insert(index, element);
                }

                if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]);
                    List<int> elementsToInsert = command.Skip(2).Select(a => Convert.ToInt32(a)).ToList();

                    nums.InsertRange(index, elementsToInsert);
                }

                if (command[0] == "contains")
                {
                    int element = int.Parse(command[1]);

                    if (nums.Contains(element))
                    {
                        Console.WriteLine(nums.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }

                if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);

                    nums.RemoveAt(index);
                }

                if (command[0] == "shift")
                {
                    int position = int.Parse(command[1]);

                    if(position > nums.Count)
                    {
                        position %= nums.Count;
                    }

                    var newNums = nums.Take(position).ToList();
                    nums.RemoveRange(0, position);
                    nums.InsertRange(nums.Count, newNums);
                }

                if (command[0] == "sumPairs")
                {
                    if (nums.Count % 2 == 0)
                    {
                        var sum = new List<int>();
                        for (int i = 0; i < nums.Count; i++)
                        {
                            sum.Add(nums[i] + nums[i + 1]);
                            i++;
                        }
                        nums.Clear();
                        nums.AddRange(sum);
                    }
                    else
                    {
                        var sum = new List<int>();
                        for (int i = 0; i < nums.Count - 1; i++)
                        {
                            sum.Add(nums[i] + nums[i + 1]);
                            i++;
                        }
                        sum.Insert(sum.Count, nums.Last());
                        nums.Clear();
                        nums.AddRange(sum);

                    }
                }

                command = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
