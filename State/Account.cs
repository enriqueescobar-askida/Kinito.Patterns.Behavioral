namespace State
{
    using System;

    /// <summary>
    /// The account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets the owner.
        /// </summary>
        public string Owner { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="owner">The owner.</param>
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this.Owner = owner;
            this.State = new SilverState(0.0, this);
        }

        /// <summary>
        /// Gets the balance.
        /// </summary>
        public double Balance
        {
            get { return this.State.Balance; }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public AnAbstractState State { get; set; }

        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void Deposit(double amount)
        {
            this.State.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}", this.State.GetType().Name);
            Console.WriteLine(String.Empty);
        }

        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void Withdraw(double amount)
        {
            this.State.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
        }

        /// <summary>
        /// Pays the interest.
        /// </summary>
        public void PayInterest()
        {
            this.State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
        }
    }
}
