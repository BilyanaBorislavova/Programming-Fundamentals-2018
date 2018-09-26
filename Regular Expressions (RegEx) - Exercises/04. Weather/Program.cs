using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<cityName>[A-Z]{2})(?<avgTemp>[0-9]+\.[0-9]+)(?<weather>[a-zA-Z]+)\|";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<double, string>> cities = new Dictionary<string, Dictionary<double, string>>();

            while (input != "end")
            {
                MatchCollection matches = regex.Matches(input);

                foreach (Match item in matches)
                {
                    var city = item.Groups["cityName"].Value;
                    var temp = double.Parse(item.Groups["avgTemp"].Value);
                    var weather = item.Groups["weather"].Value;

                    if(!cities.ContainsKey(city))
                    {
                        cities.Add(city, new Dictionary<double, string>());
                        cities[city].Add(temp, weather);
                    }
                    else
                    {
                        cities[city] = new Dictionary<double, string>();
                        cities[city].Add(temp, weather);
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in cities.OrderBy(a => a.Value.Keys.Average()))
            {
                foreach (var itemm in item.Value)
                {
                    Console.WriteLine($"{item.Key} => {itemm.Key:f2} => {itemm.Value}");
                }
            }
          
        }
    }
}
