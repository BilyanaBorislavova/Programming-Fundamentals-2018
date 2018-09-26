using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //{title} {author} {publisher} {release date} {ISBN} {price}.

            Dictionary<string, DateTime> authors = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string title = data[0];
                string author = data[1];
                string publisher = data[2];
                DateTime releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = data[4];
                double price = double.Parse(data[5]);

                if (!authors.ContainsKey(title))
                {
                    authors.Add(title, releaseDate);
                }
                else
                {
                    authors[title] = releaseDate;
                }

            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var title in authors.Where(a => a.Value > date).OrderBy(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{title.Key} -> {title.Value.Day}.{title.Value.Month:d2}.{title.Value.Year}");
            }
        }
    }
}
