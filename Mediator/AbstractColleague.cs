namespace Mediator
{
    /// <summary>
    /// The abstract colleague.
    /// </summary>
    public abstract class AbstractColleague
    {
        /// <summary>
        /// Gets the mediator.
        /// </summary>
        public AbstractMediator Mediator { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractColleague"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        protected AbstractColleague(AbstractMediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}
