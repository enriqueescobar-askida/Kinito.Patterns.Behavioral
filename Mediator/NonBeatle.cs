namespace Mediator
{
    using System;

    /// <summary>
    /// The non beatle.
    /// </summary>
    public class NonBeatle : Participant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonBeatle"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public NonBeatle(string name) : base(name)
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
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}