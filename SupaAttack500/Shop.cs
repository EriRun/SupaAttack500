using System.Numerics;

namespace SupaAttack500
{
    internal class Shop
    {
        private static void ShopSeed(Player player)
        {
            Shop shop = new();
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
                Visuals.DisplayStats(player);
                DisplayShopItems(items);
                shop.ShopSwitch(player, items, shopping);
            }
        }
        public bool ShopSwitch(Player player, List<Item> items, bool shopping)
        {
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
                    }
                    else if (player.Gold < items[0].Cost)
                    {
                        Console.WriteLine("Insufficient funds, Come back later!");
                    }
                    else
                    {
                        Visuals.DisplayStats(player);
                        player.Gold -= 17;
                        player.HealthPoints += 25;
                    }
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    if (player.Gold < items[1].Cost)
                    {
                        Console.WriteLine("Insufficient funds, Come back later!");
                    }
                    else
                    {
                        Console.Clear();
                        Visuals.DisplayStats(player);
                        player.Strength += 150;
                        player.Gold -= 500;
                    }
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    if (player.Gold < items[2].Cost)
                    {
                        Console.WriteLine("Insufficient funds, Come back later!");
                    }
                    else
                    {
                        Console.Clear();
                        Visuals.DisplayStats(player);
                        player.Strength += 7;
                        player.Gold -= 75;
                    }
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    if (player.Gold < items[3].Cost)
                    {
                        Console.WriteLine("Insufficient funds, Come back later!");
                    }
                    else
                    {
                        Console.Clear();
                        Visuals.DisplayStats(player);
                        player.Toughness += 7;
                        player.Gold -= 25;
                    }
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    if (player.Gold < items[4].Cost)
                    {
                        Console.WriteLine("Insufficient funds, Come back later!");
                    }
                    else
                    {
                        Console.Clear();
                        Visuals.DisplayStats(player);
                        player.Strength += 1000;
                        player.Gold -= 1;
                    }
                    break;

                case ConsoleKey.Escape:
                    shopping = false;
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Visuals.DisplayStats(player);
                    break;
            }

            return shopping;
        }

        public static void DisplayShopItems(List<Item> items)
        {
            foreach (var item in items)
            {
                Console.Write($"Item: {item.Name}\n"); Console.Write($"Effect: {item.Effect} {item.EffectDescription} \n"); Console.Write($"Costs: {item.Cost}\n");
                Console.WriteLine("\n");
            }
        }

        internal static void ShopKeep(Player player)
        {
            ShopSeed(player);
        }
    }
}