namespace Mediator
{
    /// <summary>
    /// The abstract mediator.
    /// </summary>
    public abstract class AbstractMediator
    {
        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="colleague">
        /// The colleague.
        /// </param>
        public abstract void Send(string message, AbstractColleague colleague);
    }
}