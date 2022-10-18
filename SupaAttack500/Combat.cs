using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SupaAttack500
{
    internal class Combat
    {
        public static void KrogvaktFight(Player player)
        {
            Krogvakt krogvakt = new Krogvakt("Krogvakt", 1, 34, 50, 9, 13);
            while (true)
            {
            if (player.HealthPoints <= 0 || krogvakt.HealthPoints <= 0) {
                    break;
                } else
                {
                    Console.WriteLine($"You enter the bar, A wild {krogvakt.Name} charges you! D:\n" +
                $"You take {krogvakt.AttackDamage} Damage");
                    player.HealthPoints -= krogvakt.AttackDamage;
                    Console.WriteLine($"You have {player.HealthPoints} Health left, Press any key to fight back!");
                    Console.ReadLine(); 
                    Console.WriteLine($"You hit the {krogvakt.Name} with a bottle! He takes {player.AttackDamage} damage!");
                    krogvakt.HealthPoints -= player.AttackDamage;
                    Console.WriteLine($"{krogvakt.Name} has {krogvakt.HealthPoints} left!");
                    //Visuals.DisplayStats(player);
                }
            }
            if (player.HealthPoints <= 0)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Console.WriteLine($"You have lost all of your Health Points. Game over.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            } else if (krogvakt.HealthPoints <= 0)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                player.ExperiencePoints += krogvakt.RewardExperience;
                player.Gold += krogvakt.RewardGold;
                Visuals.DisplayStats(player);
                Console.WriteLine($"{krogvakt.Name} was defeated, You gain {krogvakt.RewardExperience} experience and {krogvakt.RewardGold} gold!");
                Console.WriteLine($"You now have {player.Gold} gold! Stop by the store and make some lucrative trades!");
                Console.ReadLine();
            }
        }
    }
}
