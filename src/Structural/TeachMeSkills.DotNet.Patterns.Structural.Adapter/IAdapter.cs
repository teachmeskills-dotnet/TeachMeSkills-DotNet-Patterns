namespace TeachMeSkills.DotNet.Patterns.Structural.Adapter
{
    /// <summary>
    /// Adapter interface.
    /// </summary>
    /// <typeparam name="T">Source generic type.</typeparam>
    /// <typeparam name="V">Generic result type from method.</typeparam>
    /// <typeparam name="Z">Generic result type from method.</typeparam>
    public interface IAdapter<T, V, Z>
    {
        /// <summary>
        /// Souce.
        /// </summary>
        public T Source { get; }

        /// <summary>
        /// Get source data.
        /// </summary>
        /// <param name="source">Source data.</param>
        public V GetSource(T source);

        /// <summary>
        /// Result.
        /// </summary>
        public Z Result();
    }
}
