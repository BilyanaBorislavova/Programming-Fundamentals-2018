using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //{title} {author} {publisher} {release date} {ISBN} {price}.

            Dictionary<string, double> authors = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string title = data[0];
                string author = data[1];
                string publisher = data[2];
                string releaseDate = data[3];
                string isbn = data[4];
                double price = double.Parse(data[5]);

                if(!authors.ContainsKey(author))
                {
                    authors.Add(author, price);
                }
                else
                {
                    authors[author] += price;
                }

            }

            foreach (var author in authors.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
