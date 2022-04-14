namespace TeachMeSkills.DotNet.Patterns.Structural.Decorator
{
    // UNDONE: change void to V

    /// <summary>
    /// Decorator base class.
    /// </summary>
    /// <typeparam name="T">Generic result type from DecoratorComponentBase method.</typeparam>
    public abstract class DecoratorBase<T, V> : DecoratorComponentBase<T>
    {
        /// <summary>
        /// Decorator component.
        /// </summary>
        protected DecoratorComponentBase<T> _component;

        /// <summary>
        /// Constructor with params.
        /// </summary>
        /// <param name="component">Decorator component.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public DecoratorBase(DecoratorComponentBase<T> component)
        {
            _component = component ?? throw new ArgumentNullException(nameof(component));
        }

        /// <summary>
        /// Set component.
        /// </summary>
        /// <param name="component">Decorator component</param>
        public void SetComponent(DecoratorComponentBase<T> component)
        {
            _component = component ?? throw new ArgumentNullException(nameof(component));
        }

        /// <summary>
        /// Operation.
        /// </summary>
        public override T Operation()
        {
            if (_component is not null)
            {
                return _component.Operation();
            }

            return default;
        }
    }
}
