namespace State
{
    /// <summary>
    /// The gold state.
    /// </summary>
    public class GoldState : AnAbstractState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldState"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public GoldState(AnAbstractState state) : this(state.Balance, state.Account)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoldState"/> class.
        /// </summary>
        /// <param name="balance">
        /// The balance.
        /// </param>
        /// <param name="account">
        /// The account.
        /// </param>
        public GoldState(double balance, Account account)
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
            // Should come from a database
            this.Interest = 0.05;
            this.LowerLimit = 1000.0;
            this.UpperLimit = 10000000.0;
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
            if (this.Balance < 0.0)
            {
                this.Account.State = new RedState(this);
            }
            else if (this.Balance < this.LowerLimit)
            {
                this.Account.State = new SilverState(this);
            }
        }
    }
}