namespace Command
{
    /// <summary>
    /// The concrete command.
    /// </summary>
    public class ConcreteCommand : AbstractCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteCommand"/> class.
        /// </summary>
        /// <param name="receiver">
        /// The receiver.
        /// </param>
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public override void Execute()
        {
            this.Receiver.Action();
        }
    }
}