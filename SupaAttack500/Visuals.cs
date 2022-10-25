namespace SupaAttack500
{
    public class Visuals
    {
        public static void DisplayStats(Player player)
        {
            Console.SetCursorPosition(0, 0); for (int i = 0; i < Console.WindowWidth; i++) { Console.Write("-"); }
            Console.SetCursorPosition(0, 1); for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" "); if (i == Console.WindowWidth / 5 - 4 ||
                    i == (Console.WindowWidth / 5) * 2 - 4 || i == (Console.WindowWidth / 5) * 3 - 4 || i == (Console.WindowWidth / 5) * 4 - 4) { Console.Write("||"); }
            }
            Console.SetCursorPosition(12, 1); Console.Write(player.Name.ToUpper());
            Console.SetCursorPosition((Console.WindowWidth / 6 * 2 - 10), 1); Console.Write($"Level: {player.Level.ToString()}");
            var xp = 100 * player.Level;
            Console.SetCursorPosition((Console.WindowWidth / 6 * 3), 1); Console.Write($"{player.ExperiencePoints.ToString()} / {xp} XP");
            Console.SetCursorPosition((Console.WindowWidth / 6 * 4 + 5), 1); Console.Write($"{player.HealthPoints.ToString()} / {(100 + (player.Level * 10))}HP");
            Console.SetCursorPosition((Console.WindowWidth / 6 * 5 + 10), 1); Console.Write($"{player.Gold} Gold");
            Console.SetCursorPosition(0, 2); for (int i = 0; i < Console.WindowWidth; i++) { Console.Write("-"); }
        }

        public static void MenuOptions()
        {
            Console.SetCursorPosition(7, 8); Console.WriteLine("*---------------------------*         *---------------------------*         *---------------------------*");
            Console.SetCursorPosition(7, 9); Console.WriteLine("|   Press 1 to Start Game   |         |   Press 2 to Load Game    |         |  Press 3 to Save Game     |");
            Console.SetCursorPosition(7, 10); Console.WriteLine("*---------------------------*         *---------------------------*         *---------------------------*");
            Console.SetCursorPosition(20, 13); Console.WriteLine("*---------------------------*                *---------------------------*");
            Console.SetCursorPosition(20, 14); Console.WriteLine("|   Press 4 to Go To Shop   |                |   Press 5 to Exit Game    | ");
            Console.SetCursorPosition(20, 15); Console.WriteLine("*---------------------------*                *---------------------------*");
        }

        public static string DrawLogo()
        {
            string[] Logo = new string[]
            {
                  "______________________________________________________________________________________________",
                  "      __                          __                                   ____      __       __  ", "    /    )                        / |                          /      /        /    )   /    )",
                  "----\\-----------------__----__---/__|--_/_--_/_----__----__---/-__---/___-----/----/---/----/-", "     \\     /   /    /   ) /   ) /   |  /    /    /   ) /   ' /(          )   /    /   /    /  ",
                 "_(____/___(___(____/___/_(___(_/____|_(_ __(_ __(___(_(___ _/___\\__(____/___(____/___(____/___",
                "                  /                                                                           ","                 /                                                                            "
            };
            for (int i = 0; i < Logo.Length; i++)
            {
                Console.SetCursorPosition(0, i); Console.WriteLine(Logo[i]);
            }

            return null;
        }

        public static void WinScreen(Player player)
        {
            Console.Clear();
            DrawLogo();
            string[] thanks = new string[]
            {
                "   ____             _      __________             __      ", "  / __/__  ___ ____(_)__ _/ /_  __/ /  ___ ____  / /__ ___",
                " _\\ \\/ _ \\/ -_) __/ / _ `/ / / / / _ \\/ _ `/ _ \\/  '_/(_-<", "/___/ .__/\\__/\\__/_/\\_,_/_/ /_/ /_//_/\\_,_/_//_/_/\\_\\/___/",
                "   /_/                                                                                                            "
            };
            for (int i = 0; i < thanks.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 4, i + 7); Console.WriteLine($"{thanks[i]}");
            }
            string[] credits = new string[]
            {
                "Lead Producer\t|\tEric Rundqvist", "Publisher\t|\tEric Rundqvist", "Founder\t|\tEric Rundqvist","Concept Builder|\tEric Rundqvist",
                "Concept Manager|\tMarcus Medina","\t   Progamming Team",
                "Lead Programmer|\tEric Rundqvist", "Programmer 1\t|\tEric Rundqvist", "Programmer 2\t|\tEric Rundqvist", "Programmer 3\t|\tEric Rundqvist",
                "\t   Design Team", "Lead Designer\t|\tEric Rundqvist", "Animation Designer\t|\tEric Rundqvist",
                "GUI Designer\t|\tEric Rundqvist", "Designer 1\t|\tEric Rundqvist", "Designer 2\t|\tEric Rundqvist","Designer 3\t|\tEric Rundqvist",
                "BGM\t\t|\tLuKremBo", "\t      Player", $"Player\t\t|\t{player.Name}", "Hotel\t\t|\tTrivago"
            };
            for (int i = 0; i < credits.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 4 + 9, i + 13); Console.WriteLine(credits[i]);
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(90, 38); Console.WriteLine("Inspiration and ideas: Tehpson && Gatreh");
            Console.SetCursorPosition(0, 36); Console.WriteLine("Congratulations! You reached level 10! You won!");
            Console.WriteLine("Would you like to save your score?");
            Console.WriteLine("Press Y = Save Score\tPress N = Exit Game");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Y:
                    var name = player.Name;
                    var level = player.Level;
                    var experiencePoints = player.ExperiencePoints;
                    var gold = player.Gold;
                    var healthPoints = player.HealthPoints;
                    var attackDamage = player.AttackDamage;
                    var strength = player.Strength;
                    var toughness = player.Toughness;
                    name = player.Name;
                    var playerInventory = Player.PlayerInventory;
                    Program.jsonconfig.SaveScore(name, level, experiencePoints, gold, healthPoints, attackDamage, strength, toughness, player);
                    Environment.Exit(0);
                    break;

                case ConsoleKey.N:
                    Environment.Exit(0);
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}