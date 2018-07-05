namespace Command
{
    public class Invoker
    {
        /// <summary>
        /// Gets the command.
        /// </summary>
        public AbstractCommand Command { get; internal set; }

        /// <summary>
        /// The set command.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        public void SetCommand(AbstractCommand command)
        {
            this.Command = command;
        }

        /// <summary>
        /// The execute command.
        /// </summary>
        public void ExecuteCommand()
        {
            this.Command.Execute();
        }
    }
}