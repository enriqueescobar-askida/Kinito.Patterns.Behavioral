namespace Strategy
{
    using System;

    /// <summary>
    /// The corporate strategy.
    /// </summary>
    public sealed class CorporateStrategy : AbstractStrategy
    {
        /// <summary>
        /// The my rule.
        /// </summary>
        public override void MyRule()
        {
            Console.WriteLine(this.ToString());
        }
    }
}