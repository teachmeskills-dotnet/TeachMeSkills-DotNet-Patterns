namespace TeachMeSkills.DotNet.Patterns.Creational.Builder
{
    // UNDONE: change Task -> V

    /// <summary>
    /// Builder interface.
    /// </summary>
    /// <typeparam name="T">Product generic type.</typeparam>
    public interface IBuilder<T>
    {
        /// <summary>
        /// Product.
        /// </summary>
        T Product { get; }

        /// <summary>
        /// Build.
        /// </summary>
        public Task BuildAsync();
    }
}
