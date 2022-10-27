namespace SupaAttack500
{
    internal class Cheats
    {
        public static void Menu(Player player)
        {
            Console.Clear();
            Visuals.DisplayStats(player);
            Console.WriteLine($"Welcome, {player.Name}, to the Secret Cheat Menu!\n" +
                $"Please enter a valid Cheat Code to continue:");
            int i = 0;
            int.TryParse(Console.ReadLine(), out i);
            if (i == 42069)
            {
                player.Strength = 10000;
            }
            else if (i == 1337)
            {
                player.HealthPoints = 10000;
               }
            }
        }
    }