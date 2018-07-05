namespace State
{
    using System;

    /// <summary>
    /// The red state.
    /// </summary>
    public class RedState : AnAbstractState
    {
        /// <summary>
        /// Gets the service fee.
        /// </summary>
        public double ServiceFee { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedState"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public RedState(AnAbstractState state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            this.Initialize();
        }

        /// <summary>
        /// The initialize.
        /// </summary>
        private void Initialize()
        {
            // Should come from a datasource
            this.Interest = 0.0;
            this.LowerLimit = -100.0;
            this.UpperLimit = 0.0;
            this.ServiceFee = 15.00;
        }

        /// <summary>
        /// The deposit.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public override void Deposit(double amount)
        {
            this.Balance += amount;
            this.StateChangeCheck();
        }

        /// <summary>
        /// The withdraw.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public override void Withdraw(double amount)
        {
            amount = amount - this.ServiceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        /// <summary>
        /// Pays the interest.
        /// </summary>
        public override void PayInterest()
        {
            // No interest is paid
        }

        /// <summary>
        /// The state change check.
        /// </summary>
        private void StateChangeCheck()
        {
            if (this.Balance > this.UpperLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }
    }
}