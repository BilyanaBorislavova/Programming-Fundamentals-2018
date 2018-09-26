using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string thiefID = Console.ReadLine();
            int idToRecieve = int.Parse(Console.ReadLine());

            List<long> values = new List<long>();

            for (int i = 0; i < idToRecieve; i++)
            {
                long n = long.Parse(Console.ReadLine());
                values.Add(n);
            }

            if (thiefID == "sbyte")
            {
                var closest = values.Where(x => x <= sbyte.MaxValue).Max();
                Console.WriteLine(string.Join("", closest));
            }
            else if(thiefID == "int")
            {
                var closest = values.Where(x => x <= int.MaxValue).Max();
                Console.WriteLine(string.Join("", closest));
            }
            else if(thiefID == "long")
            {
                var closest = values.Where(x => x <= long.MaxValue).Max();
                Console.WriteLine(string.Join("", closest));
            }

        }
    }
}
