namespace ChainOfResponsability
{
    /// <summary>
    /// The purchase.
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase"/> class.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        /// <param name="purpose">
        /// The purpose.
        /// </param>
        public Purchase(int number, double amount, string purpose)
        {
            this.Number = number;
            this.Amount = amount;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Gets the number.
        /// </summary>
        public int Number { get; internal set; }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        public double Amount { get; internal set; }

        /// <summary>
        /// Gets the purpose.
        /// </summary>
        public string Purpose { get; internal set; }
    }
}
