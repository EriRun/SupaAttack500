using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupaAttack500
{
    public class Polis : Monster
    {
        public Polis(string name, int level, int rewardExperience, int healthPoints, int attackDamage, int rewardGold)
        {
            Name = name; Level = level;
            RewardExperience = rewardExperience; HealthPoints = healthPoints; AttackDamage = attackDamage; RewardGold = rewardGold;
        }
        public int Level { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public int HealthPoints { get; set; }
        public int AttackDamage { get; set; }
    }
}
