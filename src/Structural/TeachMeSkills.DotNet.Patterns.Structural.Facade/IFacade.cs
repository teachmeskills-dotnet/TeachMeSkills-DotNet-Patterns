namespace TeachMeSkills.DotNet.Patterns.Structural.Facade
{
    /// <summary>
    /// Facade interface.
    /// </summary>
    /// <typeparam name="T">SubSystem1 generic type.</typeparam>
    /// <typeparam name="V">SubSystem2 generic type.</typeparam>
    /// <typeparam name="Z">Generic result type from method.</typeparam>
    public interface IFacade<T, V, Z>
    {
        /// <summary>
        /// SubSystem1.
        /// </summary>
        public T SubSystem1 { get; }

        /// <summary>
        /// SubSystem2.
        /// </summary>
        public V SubSystem2 { get; }

        /// <summary>
        /// Get result.
        /// </summary>
        public Z GetResult();
    }
}
