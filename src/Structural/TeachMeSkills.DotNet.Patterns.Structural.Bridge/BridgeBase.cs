namespace TeachMeSkills.DotNet.Patterns.Structural.Bridge
{
    /// <summary>
    /// Abstraction bridge base class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BridgeBase<T>
    {
        /// <summary>
        /// Bridge interface.
        /// </summary>
        protected IBridge _implementation;

        /// <summary>
        /// Custructor with params.
        /// </summary>
        /// <param name="implementation">Bridge interface.</param>
        public BridgeBase(IBridge implementation)
        {
            _implementation = implementation ?? throw new ArgumentNullException(nameof(implementation));
        }

        /// <summary>
        /// Operation.
        /// </summary>
        public abstract T Operation();
    }
}
