namespace TeachMeSkills.DotNet.Patterns.Structural.Proxy
{
    /// <summary>
    /// Proxy interface.
    /// </summary>
    /// <typeparam name="T">Source generic type.</typeparam>
    /// <typeparam name="V">Generic result type from method.</typeparam>
    public interface IProxy<T, V>
    {
        /// <summary>
        /// Source.
        /// </summary>
        public T Source { get; }

        /// <summary>
        /// Get result.
        /// </summary>
        public V GetResult();
    }
}
