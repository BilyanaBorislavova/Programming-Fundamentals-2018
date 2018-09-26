using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> validMaterials = new Dictionary<string, int>();

            validMaterials["shards"] = 0;
            validMaterials["fragments"] = 0;
            validMaterials["motes"] = 0;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool shards = false;
            bool fragments = false;
            bool motes = false;

            string winner = string.Empty;

            while (!shards && !fragments && !motes)
            {
                string[] data = Console.ReadLine()
                                 .ToLower()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();

                for (int i = 0; i < data.Length; i += 2)
                {
                    int quantity = int.Parse(data[i]);
                    string item = data[i + 1];


                    if (validMaterials.ContainsKey(item))
                    {
                        validMaterials[item] += quantity;
                    }


                    else if (!junk.ContainsKey(item))
                    {
                        junk.Add(item, quantity);
                    }
                    else
                    {
                        junk[item] += quantity;
                    }



                    if (validMaterials["fragments"] >= 250)
                    {
                        validMaterials["fragments"] -= 250;
                        fragments = true;
                        winner = "Valanyr";
                        break;
                    }

                    else if (validMaterials["shards"] >= 250)
                    {
                        validMaterials["shards"] -= 250;
                        shards = true;
                        winner = "Shadowmourne";
                        break;
                    }

                    else if (validMaterials["motes"] >= 250)
                    {
                        validMaterials["motes"] -= 250;
                        motes = true;
                        winner = "Dragonwrath";
                        break;
                    }

                }


            }

            Console.WriteLine($"{winner} obtained!");

            foreach (var validMaterial in validMaterials.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{validMaterial.Key}: {validMaterial.Value}");
            }

            foreach (var junkMaterial in junk.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{junkMaterial.Key}: {junkMaterial.Value}");
            }


        }
    }
}
