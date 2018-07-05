namespace Memento
{
    /// <summary>
    /// The another memento.
    /// </summary>
    public class AnotherMemento
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherMemento"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public AnotherMemento(string state)
        {
            this.State = state;
        }

        /// <summary>
        /// Gets the state.
        /// </summary>
        public string State { get; internal set; }
    }
}