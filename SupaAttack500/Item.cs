using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupaAttack500
{
    public class Item
    {
        public Item(string name, int effect, int cost, string effectDescription) {Name = name; Effect = effect; Cost = cost; EffectDescription = effectDescription; }
        public string Name { get; set; }
        public int Effect { get; set; }
        public string EffectDescription { get; set; }
        public int Cost { get; set; }
    
    }
}
