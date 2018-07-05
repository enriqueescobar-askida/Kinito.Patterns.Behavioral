namespace Memento
{
    using System;

    /// <summary>
    /// The originator.
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State
        {
            get
            {
                return this.State;
            }

            set
            {
                this.State = value;
                Console.WriteLine("State = " + this.State);
            }
        }

        /// <summary>
        /// The create another memento.
        /// </summary>
        /// <returns>
        /// The <see cref="AnotherMemento"/>.
        /// </returns>
        public AnotherMemento CreateAnotherMemento()
        {
            return new AnotherMemento(this.State);
        }

        /// <summary>
        /// The set another memento.
        /// </summary>
        /// <param name="anotherMemento">
        /// The another memento.
        /// </param>
        public void SetAnotherMemento(AnotherMemento anotherMemento)
        {
            Console.WriteLine("Restoring state...");
            this.State = anotherMemento.State;
        }
    }
}