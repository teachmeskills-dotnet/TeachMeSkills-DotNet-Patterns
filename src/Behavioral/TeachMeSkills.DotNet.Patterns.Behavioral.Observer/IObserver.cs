namespace TeachMeSkills.DotNet.Patterns.Behavioral.Observer
{
    /// <summary>
    /// Observer interface.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Update.
        /// </summary>
        /// <param name="subject">Subject.</param>
        public void Update(IObserverSubject subject);
    }
}
