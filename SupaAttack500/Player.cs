namespace SupaAttack500
{
    public class Player
    {
        public Player(string name, int level, int experiencePoints, int healthPoints, int attackDamage, int gold) { this.Name = ""; this.Level = 1; this.ExperiencePoints = 0; 
            this.HealthPoints = 100; this.AttackDamage = 14; this.Gold = 0;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int Gold { get; set; }
        public int HealthPoints { get; set; }
        public int AttackDamage { get; set; }
    }
}
