namespace Strategy
{
    /// <summary>
    /// The credit sales context.
    /// </summary>
    public class CreditSalesContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditSalesContext"/> class.
        /// </summary>
        /// <param name="creditStrategy">
        /// The credit strategy.
        /// </param>
        public CreditSalesContext(AbstractStrategy creditStrategy)
        {
            this.Strategy = creditStrategy;
        }

        /// <summary>
        /// Gets the strategy.
        /// </summary>
        public AbstractStrategy Strategy { get; internal set; }

        /// <summary>
        /// The business rule.
        /// </summary>
        public void BusinessRule()
        {
            this.Strategy.MyRule();
        }
    }
}