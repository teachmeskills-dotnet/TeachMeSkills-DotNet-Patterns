namespace TeachMeSkills.DotNet.Patterns.Structural.Composite
{
    /// <summary>
    /// Composite abstract base class.
    /// </summary>
    /// <typeparam name="T1">Generic result type from method.</typeparam>
    /// <typeparam name="T2">Generic result type from another methods.</typeparam>
    public abstract class CompositeBase<T1, T2>
    {
        /// <summary>
        /// Source.
        /// </summary>
        public CompositeBase<T1, T2> Source { get; set; }

        /// <summary>
        /// Operation.
        /// </summary>
        public abstract T1 Operation();

        /// <summary>
        /// Add.
        /// </summary>
        /// <param name="component">Component.</param>
        public abstract T2 Add(CompositeBase<T1, T2> component);

        /// <summary>
        /// Remove.
        /// </summary>
        /// <param name="component">Component</param>
        /// <returns></returns>
        public abstract T2 Remove(CompositeBase<T1, T2> component);

        /// <summary>
        /// Is composite.
        /// </summary>
        /// <returns>Operation result.</returns>
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
