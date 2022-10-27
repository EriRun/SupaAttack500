using System.Media;

namespace SupaAttack500
{
    public class Logic

    {
        public static void Game()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer soundPlayer = new SoundPlayer("Biscuit.wav");
                //  Music source:
                //  https://www.youtube.com/watch?v=EtZ2m2Zm3vY&ab_channel=LuKremBo
                soundPlayer.Load();
                soundPlayer.PlayLooping();
                Console.SetWindowSize(130, 40);
                Console.SetBufferSize(130, 40);
            }
            Console.Title = "SupaAttack500!";
            Player player = new Player("", 1, 0, 100, 14, 0, 0, 0);
            Visuals.DrawLogo();
            Menu(player);
        }
        public static void Menu(Player player)
        {
            Console.WriteLine("Please enter your name:");
            player.Name = Console.ReadLine();
            bool MenuActive = true;
            while (MenuActive)
            {
                if (player.Level == 10)
                {
                    Visuals.WinScreen(player);
                }
                Console.Clear();
                Visuals.DisplayStats(player);
                Visuals.MenuOptions();
                MenuSwitch(player);
            }
        }

        public static void MenuSwitch(Player player)
        {
            int level = player.Level;
            int gold = player.Gold;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        GameRound(player);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Program.jsonconfig.LoadScore(player);
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Program.jsonconfig.HiScore(level, gold, player);
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Shop.ShopKeep(player);
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Environment.Exit(0);
                        break;

                    case ConsoleKey.Tab:
                        Cheats.Menu(player);
                        break;
                }
        }

        public static void GameRound(Player player)
        {
            Random random = new();
            var Adventure = random.Next(0, 9);
            if (Adventure == 1)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Console.WriteLine("You enter the bar... Nothing happens..");
                Console.ReadLine();
            }
            else if (Adventure >= 2 || Adventure <= 5)
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

    }
}