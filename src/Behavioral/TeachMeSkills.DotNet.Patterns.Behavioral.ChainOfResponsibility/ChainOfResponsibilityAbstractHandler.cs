namespace TeachMeSkills.DotNet.Patterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Abstract chain of responsibility handler.
    /// </summary>
    public abstract class ChainOfResponsibilityAbstractHandler : IChainOfResponsibilityHandler
    {
        /// <summary>
        /// Next handler.
        /// </summary>
        private IChainOfResponsibilityHandler _nextHandler;

        /// <summary>
        /// Set next handler.
        /// </summary>
        /// <param name="handler">Next handler.</param>
        public IChainOfResponsibilityHandler SetNext(IChainOfResponsibilityHandler handler)
        {
            _nextHandler = handler ?? throw new ArgumentNullException(nameof(handler));

            return handler;
        }

        /// <summary>
        /// Handle.
        /// </summary>
        /// <param name="request">Request.</param>
        public virtual object Handle(object request)
        {
            return _nextHandler != null 
                ? _nextHandler.Handle(request) 
                : null;
        }
    }

}
