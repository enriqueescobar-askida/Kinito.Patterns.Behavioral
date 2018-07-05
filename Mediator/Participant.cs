namespace Mediator
{
    using System;

    /// <summary>
    /// The participant.
    /// </summary>
    public class Participant
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the chatroom.
        /// </summary>
        public Chatroom Chatroom { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Participant(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="to">
        /// The to.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Send(string to, string message)
        {
            this.Chatroom.Send(this.Name, to, message);
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
        public virtual void Receive(string from, string message)
        {
            if (this.Name != null)
                Console.WriteLine("{0} to {1}: '{2}'", from, this.Name, message);
        }
    }
}
