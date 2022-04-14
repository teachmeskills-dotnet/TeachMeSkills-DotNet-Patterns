namespace TeachMeSkills.DotNet.Patterns.Creational.Factory
{
    /// <summary>
    /// Product.
    /// </summary>
    /// <typeparam name="T">Generic result type from method.</typeparam>
    public interface IProduct<T>
    {
        /// <summary>
        /// Operation.
        /// </summary>
        public T Get();
    }
}
