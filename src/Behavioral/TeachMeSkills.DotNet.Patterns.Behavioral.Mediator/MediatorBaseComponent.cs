using TeachMeSkills.DotNet.Patterns.Behavioral.Mediator;

namespace TeachMeSkills.Patterns.Mediator
{
    /// <summary>
    /// Mediator base component.
    /// </summary>
    /// <typeparam name="T">Data generic type.</typeparam>
    public abstract class MediatorBaseComponent<T>
    {
        protected IMediator<T> _mediator;

        /// <summary>
        /// Constructor with params.
        /// </summary>
        /// <param name="mediator">Mediator.</param>
        public MediatorBaseComponent(IMediator<T> mediator = null)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Set mediator.
        /// </summary>
        /// <param name="mediator">Mediator.</param>
        public void SetMediator(IMediator<T> mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
    }
}
