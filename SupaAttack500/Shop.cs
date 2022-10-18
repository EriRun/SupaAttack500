using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupaAttack500
{
    internal class Shop
    {
        private static void ShopSeed(Player player)
        {
            Console.Clear();
            Visuals.DisplayStats(player);
            List<Item> items = new List<Item>();
            items.Add(new Item("Bärs", 25, 20, "Health"));
            items.Add(new Item("Jäger-Vodka", 150, 500, "Strength"));
            items.Add(new Item("Suröl", 7, 75, "Strength"));

            foreach (var item in items)
            {
                Console.Write($"Item: {item.Name}\n"); Console.Write($"Effect: {item.Effect} {item.EffectDescription} \n"); Console.Write($"Costs: {item.Cost}\n");
                Console.WriteLine("\n");
            }
            bool shopping = true;
            while (shopping)
            {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    player.HealthPoints += 25;
                    player.Gold -= 20;
                    Visuals.DisplayStats(player);
                break;
                    case ConsoleKey.Escape:
                        shopping = false;
                        break;
                default:
                    break;
            }
            }
            Console.ReadLine();
        }
        internal static void ShopKeep(Player player)
        {
            ShopSeed(player);
        }
    }
}
