namespace TeachMeSkills.DotNet.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Product interface.
    /// </summary>
    /// <typeparam name="T">Generic result type from method.</typeparam>
    public interface IAbstractFactoryProduct<T>
    {
        /// <summary>
        /// Operation.
        /// </summary>
        public T Operation();
    }
}
