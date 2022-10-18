using System.Security.Principal;

namespace SupaAttack500
{
    public class Visuals
    {
        public static void DisplayStats(Player player)
        {
            Console.SetCursorPosition(0, 0); for (int i = 0; i < Console.WindowWidth; i++)  { Console.Write("-"); }
            Console.SetCursorPosition(0, 1); for (int i = 0; i < Console.WindowWidth; i++) {   Console.Write(" "); if (i == Console.WindowWidth / 5 - 4|| 
                    i == (Console.WindowWidth / 5)*2 -4|| i == (Console.WindowWidth / 5) * 3 - 4 || i == (Console.WindowWidth / 5) * 4 - 4) { Console.Write("||"); }}
            Console.SetCursorPosition(12, 1); Console.Write(player.Name.ToUpper());
            Console.SetCursorPosition((Console.WindowWidth / 6 * 2 - 10), 1); Console.Write($"Level: {player.Level.ToString()}");
           var xp = 100 * player.Level;
            Console.SetCursorPosition((Console.WindowWidth / 6 * 3), 1); Console.Write($"{player.ExperiencePoints.ToString()} / {xp} XP");
            Console.SetCursorPosition((Console.WindowWidth/6 * 4 + 5), 1); Console.Write($"{player.HealthPoints.ToString()} HP");
            Console.SetCursorPosition((Console.WindowWidth / 6 * 5 + 10), 1); Console.Write($"{player.Gold} Gold");
            Console.SetCursorPosition(0, 2); for (int i = 0; i < Console.WindowWidth; i++) { Console.Write("-"); }
        }

        public static void MenuOptions()
        {
            Console.SetCursorPosition(7, 8); Console.WriteLine("*---------------------------*         *---------------------------*         *---------------------------*");
            Console.SetCursorPosition(7, 9); Console.WriteLine("|   Press 1 to Start Game   |         |   Press 2 to Load Game    |         |  Press 3 to Save Game     |");
            Console.SetCursorPosition(7, 10); Console.WriteLine("*---------------------------*         *---------------------------*         *---------------------------*");
            Console.SetCursorPosition(20, 13); Console.WriteLine("*---------------------------*                *---------------------------*");
            Console.SetCursorPosition(20, 14); Console.WriteLine("|   Press 4 to Check Stats  |                |   Press 5 to Exit Game    | ");
            Console.SetCursorPosition(20, 15); Console.WriteLine("*---------------------------*                *---------------------------*");
        }
    }
}
