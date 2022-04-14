namespace TeachMeSkills.DotNet.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract factory interface.
    /// </summary>
    /// <typeparam name="T">Generic result type from first method.</typeparam>
    /// <typeparam name="V">Generic result type from second method.</typeparam>
    public interface IAbstractFactory<T, V>
        where T : IProduct<T>
        where V : IProduct<V>
    {
        /// <summary>
        /// Create first product.
        /// </summary>
        /// <returns></returns>
        public T CreateProductA();

        /// <summary>
        /// Create second product.
        /// </summary>
        /// <returns></returns>
        public V CreateProductB();
    }
}
