using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, Dictionary<string, long>> countryPopulationInfo = new Dictionary<string, Dictionary<string, long>>();

            while (data[0] != "report")
            {
                string capital = data[0];
                string country = data[1];
                long population = long.Parse(data[2]);

                if(!countryPopulationInfo.ContainsKey(country))
                {
                    countryPopulationInfo.Add(country, new Dictionary<string, long>());
                }

                if(!countryPopulationInfo[country].ContainsKey(capital))
                {
                    countryPopulationInfo[country].Add(capital, population);
                }

                data = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var country in countryPopulationInfo.OrderByDescending(a => a.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {string.Join("", country.Value.Values.Sum())})");

                foreach (var capital in country.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{capital.Key}: {capital.Value}");
                }
            }
        }
    }
}
