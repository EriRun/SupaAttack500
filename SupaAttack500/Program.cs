namespace SupaAttack500
{
    internal class Program
    {
        public static Json jsonconfig { get; set; } = new Json();

        private static void Main(string[] args)
        {
            Logic.Game();
        }
    }
}