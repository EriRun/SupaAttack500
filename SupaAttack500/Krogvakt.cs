namespace SupaAttack500
{
    public class Krogvakt : Monster
    {
        public Krogvakt(string name, int level, int rewardExperience, int healthPoints, int attackDamage, int rewardGold) { this.Name = "Krogvakt"; this.Level = 1; this.RewardExperience = 34; 
            this.HealthPoints = 50; this.AttackDamage = 9; this.RewardGold = 13; }
        public int Level { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public int HealthPoints { get; set; }
        public int AttackDamage { get; set; }
    }
}
