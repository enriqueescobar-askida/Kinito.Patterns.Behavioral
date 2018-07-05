namespace Observer
{
    using System.Collections.Generic;

    /// <summary>
    /// The abstract stock.
    /// </summary>
    public abstract class AbstractStock
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        public double Price { get; internal set; }

        /// <summary>
        /// Gets the investors.
        /// </summary>
        public List<IInvestor> Investors { get; internal set; }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        public string Symbol { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractStock"/> class.
        /// </summary>
        /// <param name="symbol">
        /// The symbol.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        public AbstractStock(string symbol, double price)
        {
            this.Symbol = symbol;
            this.Price = price;
        }

        /// <summary>
        /// The attach.
        /// </summary>
        /// <param name="investor">
        /// The investor.
        /// </param>
        public abstract void Attach(Investor investor);
    }
}