using Newtonsoft.Json;
using SupaAttack500;
using System.Net.Security;
using System.Xml.Linq;
using static SupaAttack500.Json;
using static System.Formats.Asn1.AsnWriter;

namespace SupaAttack500
{
    public class Json
    {
        //  Prop för Path till PlayerStats.json
        public static string Path { get; set; } = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlayerStats.json");
        /// <summary>
        /// Metod för att initiera Json klassen.
        /// </summary>
        public Json()
        {
            //  Ifall inte sparfilen finns, skapa en.
            if (!File.Exists(Path))
            {
                var filetype = new List<Score>();
                var jsonInput = JsonConvert.SerializeObject(filetype);
                File.WriteAllText(Path, jsonInput);
            }
        }

        /// <summary>
        /// GetScore Lista
        /// </summary>
        /// <returns>Returnerar en lista av scores</returns>
        public List<Score> GetScore() => JsonConvert.DeserializeObject<List<Score>>(File.ReadAllText(Path));
        /// <summary>
        /// Metod för att spara score till sparfilen.
        /// </summary>
        /// <param name="name">Player name</param>
        /// <param name="pix">Player pix</param>
        public void SaveScore(string name, int level,int experiencePoints, int gold, int healthPoints, int attackDamage, int strength, int toughness, Player player)
        {
            //  Importerar HiScore listan till variabel "scores"
            var scores = GetScore();
            name = player.Name;
            level = player.Level;
            experiencePoints = player.ExperiencePoints;
            gold = player.Gold;
            healthPoints = player.HealthPoints;
            attackDamage = player.AttackDamage;
            strength = player.Strength;
            toughness = player.Toughness;
            //  Lägger till score i listan
            scores.Add(new Score() { Name = name, Level = level, ExperiencePoints = experiencePoints, Gold = gold, HealthPoints = healthPoints, 
                AttackDamage = attackDamage, Strength = strength, Toughness = toughness });
            //  Sorterar listan, högst till lägst.
            scores = scores.OrderByDescending(x => x.Level).ToList();

            //  Skapar en ny variabel där scores serializas till json format.
            var jsonInput = JsonConvert.SerializeObject(scores);
            //  Skriver nya infon till sparfilen
            File.WriteAllText(Path, jsonInput);
        }
        /// <summary>
        /// Metod för att presentera HiScore meny
        /// </summary>
        /// <param name="pix">Player pix</param>
        public void HiScore(int level, int gold, Player player)
        {
            var hiScoreMenu = true;
            var name = player.Name;
            level = player.Level;
            var experiencePoints = player.ExperiencePoints;
            gold = player.Gold;
            var healthPoints = player.HealthPoints;
            var attackDamage = player.AttackDamage;
            var strength = player.Strength;
            var toughness = player.Toughness;
            while (hiScoreMenu)
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                Console.WriteLine($"Welcome to the HiScore list!\n" +
                $"Would you like to\n" +
                $"\t1 - Make an entry\n" +
                $"\t2 - Return to Menu\n");
                //  Switch som använder ReadKey
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Visuals.DisplayStats(player);
                        name = player.Name;
                        Program.jsonconfig.SaveScore(name, level, experiencePoints, gold, healthPoints, attackDamage, strength, toughness, player);
                        hiScoreMenu = false;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        hiScoreMenu = false;
                        break;
                }
            }
        }
        public void LoadScore(Player player)
        {
            if (File.Exists(Path))
            {
                Console.Clear();
                Visuals.DisplayStats(player);
                var hiScoreListan = GetScore();
                hiScoreListan = hiScoreListan.OrderByDescending(x => x.Level).ToList();
                if (hiScoreListan.Count > 0) {
                    while (true)
                    {
                        int x = 0;
                        foreach (var score in hiScoreListan)
                        {
                            x++;
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine($"{x}|Name: {score.Name}\t\tLevel: {score.Level}\tGold: {score.Gold}|");
                            Thread.Sleep(100);
                        }
                        Console.WriteLine("");
                        Console.WriteLine($"Please select a Save to Import (0 to go back to menu)");
                        int y = 0;
                        int.TryParse(Console.ReadLine(), out y);
                        if (y > 0 && y <= hiScoreListan.Count)
                        {
                            player.Name = hiScoreListan[y - 1].Name;
                            player.Level = hiScoreListan[y - 1].Level;
                            player.ExperiencePoints = hiScoreListan[y - 1].ExperiencePoints;
                            player.Gold = hiScoreListan[y - 1].Gold;
                            player.HealthPoints = hiScoreListan[y - 1].HealthPoints;
                            player.AttackDamage = hiScoreListan[y - 1].AttackDamage;
                            player.Strength = hiScoreListan[y - 1].Strength;
                            player.Toughness = hiScoreListan[y - 1].Toughness;

                            Console.Clear();
                            break;
                        }
                        else if (y == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Visuals.DisplayStats(player);
                            Console.WriteLine($"Pick a valid number!");
                        }
                    }
                }else
                {
                    Console.Clear();
                    Visuals.DisplayStats(player);
                    Console.WriteLine("There are no submitted scores!");
                    Thread.Sleep(2000);
                }
            }
        }


        /// <summary>
        /// Score modell
        /// </summary>
        public class Score
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int ExperiencePoints { get; set; }
            public int Gold { get; set; }
            public int HealthPoints { get; set; }
            public int AttackDamage { get; set; }
            public int Strength { get; set; }
            public int Toughness { get; set; }
        }
    }
}