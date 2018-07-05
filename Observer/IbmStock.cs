namespace Observer
{
    using System.Collections.Generic;

    /// <summary>
    /// The IBM stock.
    /// </summary>
    public class IbmStock : AbstractStock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IbmStock"/> class.
        /// </summary>
        /// <param name="symbol">
        /// The symbol.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        public IbmStock(string symbol, double price) : base(symbol, price)
        {
        }

        /// <summary>
        /// The attach.
        /// </summary>
        /// <param name="investor">
        /// The investor.
        /// </param>
        public override void Attach(Investor investor)
        {
            List<IInvestor> aList = this.Investors;
            aList.Add(investor);
            this.Investors = aList;
        }
    }
}