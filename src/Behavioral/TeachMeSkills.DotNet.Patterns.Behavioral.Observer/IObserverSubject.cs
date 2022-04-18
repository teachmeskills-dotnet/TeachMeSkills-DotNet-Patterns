namespace TeachMeSkills.DotNet.Patterns.Behavioral.Observer
{
    /// <summary>
    /// Subject interface.
    /// </summary>
    public interface IObserverSubject
    {
        /// <summary>
        /// Attach.
        /// </summary>
        /// <param name="observer">Observer.</param>
        public void Attach(IObserver observer);

        /// <summary>
        /// Detach.
        /// </summary>
        /// <param name="observer">Observer.</param>
        public void Detach(IObserver observer);

        /// <summary>
        /// Notify.
        /// </summary>
        public void Notify();
    }
}
