namespace Mediator
{
    using System;

    /// <summary>
    /// The last colleague.
    /// </summary>
    public class LastColleague : AbstractColleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastColleague"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        public LastColleague(AbstractMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Send(string message)
        {
            this.Mediator.Send(message, this);
        }

        /// <summary>
        /// The notify.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Notify(string message)
        {
            Console.WriteLine("LastColleague gets message: " + message);
        }
    }
}