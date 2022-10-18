namespace SupaAttack500
{
    public class Player
    {
        public Player(string name, int level, int experiencePoints, int healthPoints, int attackDamage, int gold) { Name = name; Level = level;
            ExperiencePoints = experiencePoints; HealthPoints = healthPoints; AttackDamage = attackDamage; Gold = gold;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int Gold { get; set; }
        public int HealthPoints { get; set; }
        public int AttackDamage { get; set; }
    }
}
