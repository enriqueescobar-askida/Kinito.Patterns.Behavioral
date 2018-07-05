namespace Strategy
{
    /// <summary>
    /// The another context.
    /// </summary>
    public class AnotherContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherContext"/> class.
        /// </summary>
        /// <param name="anotherStrategy">
        /// The another strategy.
        /// </param>
        public AnotherContext(AnotherAbstractStrategy anotherStrategy)
        {
            this.AnotherStrategy = anotherStrategy;
        }

        /// <summary>
        /// Gets the another strategy.
        /// </summary>
        public AnotherAbstractStrategy AnotherStrategy { get; internal set; }

        /// <summary>
        /// The context interface.
        /// </summary>
        public void ContextInterface()
        {
            this.AnotherStrategy.AlgorithmInterface();
        }
    }
}