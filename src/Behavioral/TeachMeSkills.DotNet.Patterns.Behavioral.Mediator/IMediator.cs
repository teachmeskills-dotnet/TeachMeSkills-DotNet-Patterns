namespace TeachMeSkills.DotNet.Patterns.Behavioral.Mediator
{
    /// <summary>
    /// Mediator interface.
    /// </summary>
    /// <typeparam name="T">Data generic type.</typeparam>
    public interface IMediator<T>
    {
        /// <summary>
        /// Notify.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="param">Data.</param>
        public void Notify(object sender, T param);
    }
}
