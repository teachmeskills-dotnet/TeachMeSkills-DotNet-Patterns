namespace TeachMeSkills.DotNet.Patterns.Behavioral.State
{
    /// <summary>
    /// State base class.
    /// </summary>
    public abstract class StateBase
    {
        /// <summary>
        /// Context.
        /// </summary>
        protected IStateContext _context;

        /// <summary>
        /// Set new context.
        /// </summary>
        /// <param name="context">New context.</param>
        public void SetContext(IStateContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// First handler.
        /// </summary>
        public abstract void Handle1();
    }
}