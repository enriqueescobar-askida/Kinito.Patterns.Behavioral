namespace Mediator
{
    /// <summary>
    /// The mediator.
    /// </summary>
    public class Mediator : AbstractMediator
    {
        /// <summary>
        /// Gets the first colleague.
        /// </summary>
        public FirstColleague FirstColleague { get; internal set; }

        /// <summary>
        /// Gets the last colleague.
        /// </summary>
        public LastColleague LastColleague { get; internal set; }

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="colleague">
        /// The colleague.
        /// </param>
        public override void Send(string message, AbstractColleague colleague)
        {
            if (colleague == this.FirstColleague)
            {
                this.LastColleague.Notify(message);
            }
            else
            {
                this.FirstColleague.Notify(message);
            }
        }
    }
}