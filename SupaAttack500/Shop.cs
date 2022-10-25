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
                Visuals.DisplayStats(player);
                foreach (var item in items)
                {
                    Console.Write($"Item: {item.Name}\n"); Console.Write($"Effect: {item.Effect} {item.EffectDescription} \n"); Console.Write($"Costs: {item.Cost}\n");
                    Console.WriteLine("\n");
                }
                bool addToInventory = true;
                Item shopChoice = null;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        if (player.HealthPoints >= (100 + (player.Level * 10)))
                        {
                            Console.Clear();
                            Visuals.DisplayStats(player);
                            Console.WriteLine("You already have maximum health");
                            addToInventory = false;
                            Thread.Sleep(1000);

                            break;
                        }
                        else if (player.Gold < items[0].Cost)
                        {
                            Console.WriteLine("Insufficient funds, Come back later!");
                            addToInventory = false;
                        }
                        else
                        {
                            shopChoice = items[0];
                            Visuals.DisplayStats(player);
                        }
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (player.Gold < items[1].Cost)
                        {
                            Console.WriteLine("Insufficient funds, Come back later!");
                            addToInventory = false;
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
                            addToInventory = false;
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
                            addToInventory = false;
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
                            addToInventory = false;
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
                        addToInventory = false;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Visuals.DisplayStats(player);
                        addToInventory = false;
                        break;
                }
               while (addToInventory)
                {
                var addItem = Player.PlayerInventory.Find(x => x.Name == shopChoice.Name);
                if (addItem != null)
                {
                    addItem.Quantity++;
                }
                else
                {
                    Player.PlayerInventory.Add(new Item(shopChoice.Name, shopChoice.Effect, shopChoice.Cost, shopChoice.EffectDescription, 1));
                        player.Gold -= shopChoice.Cost;
                }
                Console.Clear();
                Visuals.DisplayStats(player);
                //Console.WriteLine(addItem.Quantity);
                for (int i = 0; i < Player.PlayerInventory.Count; i++)
                {
                    Console.WriteLine($"{Player.PlayerInventory[0].Name}\t{Player.PlayerInventory[0].Quantity}");
                }
                addToInventory = false;
                Console.ReadLine();
                } 
            }
        }

        internal static void ShopKeep(Player player)
        {
            ShopSeed(player);
        }
    }
}