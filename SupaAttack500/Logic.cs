namespace SupaAttack500
{
    public class Logic
    {
        public static void Menu(Player player)
        {
            Console.WriteLine("Please enter your name:");
            player.Name = Console.ReadLine();
            bool MenuActive = true;
            Console.WriteLine(player.Name);
            while (MenuActive)
            {
                Visuals.MenuOptions();
                Visuals.DisplayStats(player);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        GameRound(player);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Shop.ShopKeep(player);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            
        }
        public static void GameRound(Player player)
        {
            Random random = new();
            var Adventure = random.Next(0,9);
            if (Adventure == 1)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Console.WriteLine("You enter the bar... Nothing happens..");
                Console.ReadLine();
            }
            else if (Adventure == 2 || Adventure == 4 || Adventure == 6 || Adventure == 8)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Combat.KrogvaktFight(player);
                
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Combat.PolisFight(player);
//                Console.WriteLine("You tried to enter the bar, the police outside won't let you in! \n" +
//                    "You start a fight!");
            }
        }
        public static void Game()
        {
            Console.SetWindowSize(130, 40);
            Console.SetBufferSize(130, 40);
            Player player = new Player("", 1, 0, 100, 14, 0, 0, 0);
            Menu(player);
        }
    }
}
