namespace Mediator
{
    using System;

    /// <summary>
    /// The beatle.
    /// </summary>
    public class Beatle : Participant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beatle"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Beatle(string name) : base(name)
        {
        }

        /// <summary>
        /// The receive.
        /// </summary>
        /// <param name="from">
        /// The from.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}