namespace Observer
{
    /// <summary>
    /// The Investor interface.
    /// </summary>
    public interface IInvestor
    {
        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="stock">
        /// The stock.
        /// </param>
        void Update(AbstractStock stock);
    }
}