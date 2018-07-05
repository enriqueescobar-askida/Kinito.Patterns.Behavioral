namespace State
{
    /// <summary>
    /// The an abstract state.
    /// </summary>
    public abstract class AnAbstractState
    {
        /// <summary>
        /// Gets the interest.
        /// </summary>
        public double Interest { get; internal set; }

        /// <summary>
        /// Gets the lower limit.
        /// </summary>
        public double LowerLimit { get; internal set; }

        /// <summary>
        /// Gets the upper limit.
        /// </summary>
        public double UpperLimit { get; internal set; }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// The deposit.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public abstract void Deposit(double amount);

        /// <summary>
        /// The withdraw.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public abstract void Withdraw(double amount);

        /// <summary>
        /// The pay interest.
        /// </summary>
        public abstract void PayInterest();
    }
}