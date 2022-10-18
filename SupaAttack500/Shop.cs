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
            items.Add(new Item("bärs", 5, 0) );
            items.Add(new Item("Jäger-Vodka", 150, 500));

            foreach (var item in items)
            {
                Console.WriteLine(item.Name); Console.WriteLine(item.Effect); Console.WriteLine(item.Cost);
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        internal static void ShopKeep(Player player)
        {
            ShopSeed(player);
        }
    }
}
