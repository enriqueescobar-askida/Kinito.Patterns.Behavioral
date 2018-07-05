namespace Observer
{
    using System;

    /// <summary>
    /// The investor.
    /// </summary>
    public class Investor : IInvestor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Investor"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Investor(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the stock.
        /// </summary>
        public AbstractStock Stock { get; internal set; }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="stock">
        /// The stock.
        /// </param>
        public void Update(AbstractStock stock)
        {
            this.Stock = stock;
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", this.Name, stock.Symbol, stock.Price);
        }
    }
}