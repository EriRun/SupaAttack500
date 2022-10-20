using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SupaAttack500
{
    internal class Cheats
    {
        public static void Menu(Player player)
        {
            //while (true)
            //{

            Console.Clear();
            Visuals.DisplayStats(player);
            Console.WriteLine($"Welcome, {player.Name}, to the Secret Cheat Menu!\n" +
                $"Please enter a valid Cheat Code to continue:");
            int i = 0;
            int.TryParse(Console.ReadLine(), out i);
            if (i == 42069)
            {
                player.Strength = 10000;
            } else if (i == 1337)
                {
                    player.HealthPoints = 10000;
                }
            //}
        }
    }
}
