namespace SupaAttack500
{
    public class Player
    {
        public static List<Item> PlayerInventory { get; set; } = new List<Item>();

        public Player(string name, int level, int experiencePoints, int healthPoints, int attackDamage, int gold, int strength, int toughness)
        {
            Name = name; Level = level;
            ExperiencePoints = experiencePoints; HealthPoints = healthPoints; AttackDamage = attackDamage; Gold = gold; Strength = strength; Toughness = toughness;
        }

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