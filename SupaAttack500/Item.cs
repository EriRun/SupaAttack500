using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupaAttack500
{
    public class Item
    {
        public Item(string name, int effect, int cost) {this.Name = ""; this.Effect = 0; this.Cost = 0; }
        public string Name { get; set; }
        public int Effect { get; set; }
        public int Cost { get; set; }
    
    }
}
