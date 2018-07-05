namespace Mediator
{
    /// <summary>
    /// The abstract chatroom.
    /// </summary>
    public abstract class AbstractChatroom
    {
        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="participant">
        /// The participant.
        /// </param>
        public abstract void Register(Participant participant);

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="from">
        /// The from.
        /// </param>
        /// <param name="to">
        /// The to.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public abstract void Send(string from, string to, string message);
    }
}