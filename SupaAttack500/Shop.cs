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
            items.Add(new Item("Bärs", 25, 17, "Health"));
            items.Add(new Item("Jäger-Vodka", 150, 500, "Strength"));
            items.Add(new Item("Suröl", 7, 75, "Strength"));
            items.Add(new Item("Moscow Mule", 5, 25, "Toughness"));
            items.Add(new Item("Hot n' Sweet", 1000, 1, "Strength"));

            bool shopping = true;
            while (shopping)
            {
            foreach (var item in items)
            {
                Console.Write($"Item: {item.Name}\n"); Console.Write($"Effect: {item.Effect} {item.EffectDescription} \n"); Console.Write($"Costs: {item.Cost}\n");
                Console.WriteLine("\n");
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    if (player.HealthPoints >= (100 + (player.Level * 10)))
                        {
                            Console.Clear();
                            Visuals.DisplayStats(player);
                            Console.WriteLine("You already have maximum health");
                            Thread.Sleep(1000);
                            break;
                        } else {
                    player.HealthPoints += 25;
                    player.Gold -= 17;
                    Visuals.DisplayStats(player);
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        player.Strength += 7;
                        player.Gold -= 75;
                        Visuals.DisplayStats(player);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        player.Toughness += 7;
                        player.Gold -= 25;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        player.Strength += 1000;
                        player.Gold -= 1;
                        break;
                    case ConsoleKey.Escape:
                        shopping = false;
                        Console.Clear();
                        break;
                default:
                    break;
            }
            }
        }
        internal static void ShopKeep(Player player)
        {
            ShopSeed(player);
        }
    }
}
