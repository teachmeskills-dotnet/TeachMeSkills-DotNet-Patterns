namespace TeachMeSkills.DotNet.Patterns.Behavioral.State
{
    /// <summary>
    /// State context interface.
    /// </summary>
    public interface IStateContext
    {
        /// <summary>
        /// State.
        /// </summary>
        public StateBase State { get; }

        /// <summary>
        /// Transition to new state.
        /// </summary>
        /// <param name="state">New state.</param>
        public void TransitionTo(StateBase state);

        /// <summary>
        /// First request.
        /// </summary>
        public void Request1();
    }
}
