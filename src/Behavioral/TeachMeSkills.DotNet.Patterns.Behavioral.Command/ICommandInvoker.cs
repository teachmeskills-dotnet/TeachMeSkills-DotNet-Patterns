namespace TeachMeSkills.DotNet.Patterns.Behavioral.Command
{
    // UNDONE: change void to T

    /// <summary>
    /// Command invoker interface.
    /// </summary>
    public interface ICommandInvoker
    {
        /// <summary>
        /// Set first command.
        /// </summary>
        /// <param name="command">Command interface.</param>
        public void Set1(ICommand command);

        /// <summary>
        /// Do.
        /// </summary>
        public void Do();
    }
}
