namespace TeachMeSkills.DotNet.Patterns.Behavioral.Stategy
{
    /// <summary>
    /// Strategy context interface.
    /// </summary>
    public interface IStrategyContext
    {
        /// <summary>
        /// Strategy.
        /// </summary>
        public IStrategy Strategy { get; }

        /// <summary>
        /// Set strategy.
        /// </summary>
        /// <param name="strategy">Strategy.</param>
        public void SetStrategy(IStrategy strategy);

        /// <summary>
        /// Do.
        /// </summary>
        public void Do();
    }
}
