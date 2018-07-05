namespace Mediator
{
    using System;

    /// <summary>
    /// The first colleague.
    /// </summary>
    public class FirstColleague : AbstractColleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstColleague"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        public FirstColleague(AbstractMediator mediator) : base(mediator)
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
            Console.WriteLine("FirstColleague gets message: " + message);
        }
    }
}