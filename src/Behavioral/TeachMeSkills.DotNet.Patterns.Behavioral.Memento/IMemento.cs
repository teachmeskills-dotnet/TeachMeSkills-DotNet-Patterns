namespace TeachMeSkills.DotNet.Patterns.Behavioral.Memento
{
    /// <summary>
    /// Memento interface.
    /// </summary>
    /// <typeparam name="T">State generic type.</typeparam>
    /// <typeparam name="V">Method return generic type.</typeparam>
    public interface IMemento<T, V>
    {
        /// <summary>
        /// State.
        /// </summary>
        public T State { get; }

        /// <summary>
        /// Date.
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Get name.
        /// </summary>
        V GetName();
    }
}
