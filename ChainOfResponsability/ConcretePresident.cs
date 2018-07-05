namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete president.
    /// </summary>
    public class ConcretePresident : AbstractApprover
    {
        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="purchase">
        /// The purchase.
        /// </param>
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            else
                Console.WriteLine("Request# {0} requires an executive meeting!", purchase.Number);
        }
    }
}