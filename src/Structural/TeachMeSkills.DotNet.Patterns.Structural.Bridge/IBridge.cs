namespace TeachMeSkills.DotNet.Patterns.Structural.Bridge
{
    // UNDONE: change Task -> V

    /// <summary>
    /// Bridge interface.
    /// </summary>
    public interface IBridge
    {
        /// <summary>
        /// Operation.
        /// </summary>
        /// <returns></returns>
        Task Operation();
    }
}
