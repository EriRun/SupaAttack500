namespace SupaAttack500
{
    internal class Program
    {
        #region Public Properties

        public static Json jsonconfig { get; set; } = new Json();

        #endregion Public Properties

        #region Private Methods

        private static void Main(string[] args)
        {
            Logic.Game();
        }

        #endregion Private Methods
    }
}