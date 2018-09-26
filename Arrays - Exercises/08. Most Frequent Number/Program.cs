using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var most = n.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();

            Console.WriteLine(most);

        }
    }
}
