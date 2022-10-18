namespace SupaAttack500
{
    public class Player
    {
        public Player(string name, int level, int experiencePoints, int healthPoints, int attackDamage, int gold) { this.Name = name; this.Level = level;
            this.ExperiencePoints = experiencePoints; this.HealthPoints = healthPoints; this.AttackDamage = attackDamage; this.Gold = gold;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int Gold { get; set; }
        public int HealthPoints { get; set; }
        public int AttackDamage { get; set; }
    }
}
