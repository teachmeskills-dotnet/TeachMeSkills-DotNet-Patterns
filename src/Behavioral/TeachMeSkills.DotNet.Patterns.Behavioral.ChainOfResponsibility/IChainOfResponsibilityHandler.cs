namespace TeachMeSkills.DotNet.Patterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Chain of responsibility interface.
    /// </summary>
    public interface IChainOfResponsibilityHandler
    {
        /// <summary>
        /// Set next handler.
        /// </summary>
        /// <param name="handler">Next handler.</param>
        IChainOfResponsibilityHandler SetNext(IChainOfResponsibilityHandler handler);

        /// <summary>
        /// Handle.
        /// </summary>
        /// <param name="request">Request.</param>
        object Handle(object request);
    }
}
