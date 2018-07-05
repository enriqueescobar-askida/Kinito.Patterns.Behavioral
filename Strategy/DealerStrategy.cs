namespace Strategy
{
    using System;

    /// <summary>
    /// The dealer strategy.
    /// </summary>
    public sealed class DealerStrategy : AbstractStrategy
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