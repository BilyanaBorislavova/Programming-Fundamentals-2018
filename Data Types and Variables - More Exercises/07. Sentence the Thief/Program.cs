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

            double closest = 0;
            double sentence = 0;

            for (int i = 0; i < idToRecieve; i++)
            {
                long n = long.Parse(Console.ReadLine());
                values.Add(n);
            }

            if (thiefID == "sbyte")
            {
                closest = values.Where(x => x <= sbyte.MaxValue).Max();

                if (closest < 0 && closest < sbyte.MinValue)
                {
                    sentence += Math.Ceiling(closest / sbyte.MinValue);
                }
                else if (closest > 0 && closest > sbyte.MaxValue)
                {
                    sentence += Math.Ceiling(closest / sbyte.MaxValue);
                }
                else
                {
                    sentence = 1;
                }

                if(sentence <= 1)
                {
                    Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} year");
                }
                else
                {
                    Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} years");
                }

            }
            else if (thiefID == "int")
            {
                closest = values.Where(x => x <= int.MaxValue).Max();

                if (closest < 0 && closest < sbyte.MinValue)
                {
                    sentence += Math.Ceiling(closest / sbyte.MinValue);
                }
                else if (closest > 0 && closest > sbyte.MaxValue)
                {
                    sentence += Math.Ceiling(closest / sbyte.MaxValue);
                }
                else
                {
                    sentence = 1;
                }

                if (sentence <= 1)
                {
                    Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} year");
                }
                else
                {
                    Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} years");
                }
            }
            else if (thiefID == "long")
            {
                closest = values.Where(x => x <= long.MaxValue).Max();

                if (closest < 0 && closest < sbyte.MinValue)
                {
                    sentence += Math.Ceiling(closest / sbyte.MinValue);
                }
                else if (closest > 0 && closest > sbyte.MaxValue)
                {
                    sentence += Math.Ceiling(closest / sbyte.MaxValue);
                }
                else
                {
                    sentence = 1;
                }

                if (sentence <= 1)
                {
                    Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} year");
                }
                else
                {
                    Console.WriteLine($"Prisoner with id {closest} is sentenced to {sentence} years");
                }
            }


        }
    }
}
