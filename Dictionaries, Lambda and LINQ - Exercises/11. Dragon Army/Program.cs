using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal initialHealth = 250;
            decimal initialDamage = 45;
            decimal initialArmor = 10;

            decimal resultOne = 0;
            decimal resultTwo = 0;
            decimal resultThree = 0;

            decimal damage = 0;
            decimal health = 0;
            decimal armor = 0;

            string emptyDamage = string.Empty;
            string emptyHealth = string.Empty;
            string emptyArmor = string.Empty;

            Dictionary<string, Dictionary<string, List<decimal>>> dragons = new Dictionary<string, Dictionary<string, List<decimal>>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = data[0];
                string name = data[1];

                if(decimal.TryParse(data[2], out resultOne) == false)
                {
                    emptyDamage = "null";
                    damage = initialDamage;
                }
                else
                {
                    damage = decimal.Parse(data[2]);
                }

                if (decimal.TryParse(data[3], out resultTwo) == false)
                {
                    emptyHealth = "null";
                    health = initialHealth;
                }
                else
                {
                    health = decimal.Parse(data[3]);
                }

                if (decimal.TryParse(data[4], out resultThree) == false)
                {
                    emptyArmor = "null";
                    armor = initialArmor;
                }
                else
                {
                    armor = decimal.Parse(data[4]);
                }


               if(!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<decimal>>()); 
                }

               if(!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new List<decimal>());
                    dragons[type][name].Add(damage);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
               else
                {
                    dragons[type][name][0] = damage;
                    dragons[type][name][1] = health;
                    dragons[type][name][2] = armor;
                }
            }

            foreach (var dragon in dragons)
            {
                decimal damageType = dragon.Value.Select(a => a.Value[0]).Average();
                decimal healthType = dragon.Value.Select(a => a.Value[1]).Average();
                decimal armorType = dragon.Value.Select(a => a.Value[2]).Average();

                Console.WriteLine($"{dragon.Key}::({damageType:f2}/{healthType:f2}/{armorType:f2})");

                foreach (var value in dragon.Value.OrderBy(a => a.Key))
                {
                    Console.WriteLine($"-{value.Key} -> damage: {value.Value[0]}, health: {value.Value[1]}, armor: {value.Value[2]}");
                }
            }
        }
    }
}
