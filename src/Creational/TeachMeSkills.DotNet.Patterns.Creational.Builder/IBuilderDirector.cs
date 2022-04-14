namespace TeachMeSkills.DotNet.Patterns.Creational.Builder
{
    // UNDONE: change Task -> V

    /// <summary>
    /// Director interface.
    /// </summary>
    /// <typeparam name="T">Builder generic type.</typeparam>
    public interface IBuilderDirector<T>
    {
        /// <summary>
        /// Builder.
        /// </summary>
        T Builder { get; }

        /// <summary>
        /// Build minimal viable product.
        /// </summary>
        public Task BuildMinimalViableProduct();

        /// <summary>
        /// Build full featured product.
        /// </summary>
        public Task BuildFullFeaturedProduct();
    }
}
