namespace TeachMeSkills.DotNet.Patterns.Structural.Decorator
{
    /// <summary>
    /// Decorator component base class.
    /// </summary>
    /// <typeparam name="T">Generic result type from method.</typeparam>
    public abstract class DecoratorComponentBase<T>
    {
        /// <summary>
        /// Operation.
        /// </summary>
        public abstract T Operation();
    }
}