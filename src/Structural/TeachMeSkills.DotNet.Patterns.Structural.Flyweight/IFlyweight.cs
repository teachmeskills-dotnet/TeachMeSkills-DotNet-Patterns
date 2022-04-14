namespace TeachMeSkills.DotNet.Patterns.Structural.Flyweight
{
    // UNDONE: change void -> V

    /// <summary>
    /// Flyweight interface.
    /// </summary>
    /// <typeparam name="T">Source generic type.</typeparam>
    public interface IFlyweight<T>
    {
        /// <summary>
        /// Source.
        /// </summary>
        public T Source { get; }

        /// <summary>
        /// Operation.
        /// </summary>
        /// <param name="uniqueState">Unique state.</param>
        public void Operation(T uniqueState);
    }
}
