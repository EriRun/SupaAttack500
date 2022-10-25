namespace SupaAttack500
{
    internal class Combat
    {
        public static void KrogvaktFight(Player player)
        {
            Krogvakt krogvakt = new Krogvakt("Krogvakt", 1, 34, 50, 9, (19 + (player.Level * 2)));
            while (true)
            {
                Visuals.DisplayStats(player);
                if (player.HealthPoints <= 0 || krogvakt.HealthPoints <= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"You enter the bar, A wild {krogvakt.Name} charges you! D:\n" +
                $"You take {krogvakt.AttackDamage - player.Toughness} Damage");
                    if (player.Toughness < krogvakt.AttackDamage) { player.HealthPoints -= krogvakt.AttackDamage - player.Toughness; } else { player.HealthPoints -= 0; };
                    Console.WriteLine($"You have {player.HealthPoints} Health left, Press any key to fight back!");
                    Console.ReadLine();
                    Console.WriteLine($"You hit the {krogvakt.Name} with a bottle! He takes {player.AttackDamage + player.Strength} damage!");
                    krogvakt.HealthPoints -= (player.AttackDamage + player.Strength);
                    Console.WriteLine($"{krogvakt.Name} has {krogvakt.HealthPoints} left!");
                    Console.Write("Press any key to Continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (player.HealthPoints <= 0)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Console.WriteLine($"You have lost all of your Health Points. Game over.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else if (krogvakt.HealthPoints <= 0)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                player.ExperiencePoints += krogvakt.RewardExperience;
                player.Gold += krogvakt.RewardGold;
                Visuals.DisplayStats(player);
                Console.WriteLine($"{krogvakt.Name} was defeated, You gain {krogvakt.RewardExperience} experience and {krogvakt.RewardGold} gold!");
                Console.WriteLine($"You now have {player.Gold} gold! Stop by the store and make some lucrative trades!");
                Console.Write("Press any key to Continue.");
                Console.ReadLine();
            }
            if (player.ExperiencePoints > (100 * player.Level))
            {
                player.Level++;
                player.ExperiencePoints = 0;
                if (player.HealthPoints <= 100 + (player.Level * 10)) { player.HealthPoints = 100 + (player.Level * 10); }
            }
        }

        public static void PolisFight(Player player)
        {
            Polis polis = new Polis("Polis", 1, 54 + (player.Level * 4), (34 + (player.Level * 3)), 22, (18 + (player.Level * 2)));
            while (true)
            {
                Visuals.DisplayStats(player);
                Random random = new Random();
                int rnd = random.Next(1, 22) + (player.Level * 2);
                polis.AttackDamage = rnd;
                if (player.HealthPoints <= 0 || polis.HealthPoints <= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"You enter the bar, A wild {polis.Name} charges you! D:\n" +
                $"You take {polis.AttackDamage - player.Toughness} Damage");
                    if (player.Toughness < polis.AttackDamage) { player.HealthPoints -= polis.AttackDamage - player.Toughness; } else { player.HealthPoints -= 0; };
                    //player.HealthPoints -= polis.AttackDamage - player.Toughness;
                    Console.WriteLine($"You have {player.HealthPoints} Health left, Press any key to fight back!");
                    Console.ReadLine();
                    Console.WriteLine($"You hit the {polis.Name} with a bottle! He takes {player.AttackDamage + player.Strength} damage!");
                    polis.HealthPoints -= (player.AttackDamage + player.Strength);
                    Console.WriteLine($"{polis.Name} has {polis.HealthPoints} left!");
                    Console.Write("Press any key to Continue.");
                    Console.ReadLine();
                    Console.Clear();

                    //Visuals.DisplayStats(player);
                }
            }
            if (player.HealthPoints <= 0)
            {
                Console.Clear();
                Visuals.DrawLogo();
                Console.WriteLine($"You have lost all of your Health Points. Game over.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else if (polis.HealthPoints <= 0)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                player.ExperiencePoints += polis.RewardExperience;
                player.Gold += polis.RewardGold;
                Visuals.DisplayStats(player);
                Console.WriteLine($"{polis.Name} was defeated, You gain {polis.RewardExperience} experience and {polis.RewardGold} gold!");
                Console.WriteLine($"You now have {player.Gold} gold! Stop by the store and make some lucrative trades!");
                Console.Write("Press any key to Continue.");
                Console.ReadLine();
            }
            if (player.ExperiencePoints > (100 * player.Level))
            {
                player.Level++;
                player.ExperiencePoints = 0;
                if (player.HealthPoints <= 100 + (player.Level * 10)) { player.HealthPoints = 100 + (player.Level * 10); }
            }
        }
        public static void Battle()
        {

        }
    }
}