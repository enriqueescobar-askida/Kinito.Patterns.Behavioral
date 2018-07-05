namespace State
{
    /// <summary>
    /// The silver state.
    /// </summary>
    public class SilverState : AnAbstractState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverState"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public SilverState(AnAbstractState state) : this(state.Balance, state.Account)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverState"/> class.
        /// </summary>
        /// <param name="balance">
        /// The balance.
        /// </param>
        /// <param name="account">
        /// The account.
        /// </param>
        public SilverState(double balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            this.Initialize();
        }

        /// <summary>
        /// The initialize.
        /// </summary>
        private void Initialize()
        {
            // Should come from a datasource
            this.Interest = 0.0;
            this.LowerLimit = 0.0;
            this.UpperLimit = 1000.0;
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
            this.Balance -= amount;
            this.StateChangeCheck();
        }

        /// <summary>
        /// The pay interest.
        /// </summary>
        public override void PayInterest()
        {
            this.Balance += this.Interest * this.Balance;
            this.StateChangeCheck();
        }

        /// <summary>
        /// The state change check.
        /// </summary>
        private void StateChangeCheck()
        {
            if (this.Balance < this.LowerLimit)
            {
                this.Account.State = new RedState(this);
            }
            else if (this.Balance > this.UpperLimit)
            {
                this.Account.State = new GoldState(this);
            }
        }
    }
}