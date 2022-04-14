namespace TeachMeSkills.DotNet.Patterns.Creational.Singleton
{
    // UNDONE: how to use?

    /// <summary>
    /// Singleton.
    /// </summary>
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        /// <summary>
        /// Get instance.
        /// </summary>
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
