namespace Command
{
    /// <summary>
    /// The an abstract command.
    /// </summary>
    public abstract class AnAbstractCommand
    {
        /// <summary>
        /// The execute.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Uns the execute.
        /// </summary>
        public abstract void UnExecute();
    }
}