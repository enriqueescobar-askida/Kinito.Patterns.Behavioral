namespace Mediator
{
    using System.Collections.Generic;

    /// <summary>
    /// The chatroom.
    /// </summary>
    public class Chatroom : AbstractChatroom
    {
        /// <summary>
        /// The participants.
        /// </summary>
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="participant">
        /// The participant.
        /// </param>
        public override void Register(Participant participant)
        {
            if (!this.participants.ContainsValue(participant))
            {
                this.participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

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
        public override void Send(string from, string to, string message)
        {
            Participant participant = this.participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}