namespace State
{
    using System;

    /// <summary>
    /// The context.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public Context(AbstractState state)
        {
            this.State = state;
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public AbstractState State
        {
            get
            {
                return this.State;
            }
            set
            {
                this.State = value;
                Console.WriteLine("State: " + this.State.GetType().Name);
            }
        }

        /// <summary>
        /// The request.
        /// </summary>
        public void Request()
        {
            this.State.Handle(this);
        }
    }
}