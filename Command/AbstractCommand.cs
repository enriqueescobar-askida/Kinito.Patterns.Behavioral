namespace Command
{
    /// <summary>
    /// The abstract command.
    /// </summary>
    public abstract class AbstractCommand
    {
        /// <summary>
        /// Gets the receiver.
        /// </summary>
        public Receiver Receiver { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCommand"/> class.
        /// </summary>
        /// <param name="receiver">
        /// The receiver.
        /// </param>
        protected AbstractCommand(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        /// <summary>
        /// The execute.
        /// </summary>
        public abstract void Execute();
    }
}
