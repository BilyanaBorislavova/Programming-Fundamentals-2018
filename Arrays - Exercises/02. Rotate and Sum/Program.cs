using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Count];
        
            for (int i = 0; i < rotations; i++)
            {
                var lastElement = nums.ElementAt(nums.Count - 1);
                nums.RemoveAt(nums.Count - 1);
                nums.Insert(0, lastElement);

                for (int j = 0; j < nums.Count; j++)
                {
                    sum[j] += nums[j];
                }

            }

            Console.WriteLine(string.Join(" ", sum));
           

        }
    }
}
