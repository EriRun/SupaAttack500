namespace SupaAttack500
{
    public class Item
    {
        public Item(string name, int effect, int cost, string effectDescription, int? quantity = null)
        { Name = name; Effect = effect; Cost = cost; EffectDescription = effectDescription; Quantity = quantity; }

        public string Name { get; set; }
        public int Effect { get; set; }
        public string EffectDescription { get; set; }
        public int Cost { get; set; }
        public int? Quantity { get; set; }
    }
}