using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> n = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                char[] reversedElement = nums[i].ToString().Reverse().ToArray();
                n.Add(int.Parse(string.Join("", reversedElement)));
            }

            Console.WriteLine(n.Sum());
            
          
        }
    }
}
