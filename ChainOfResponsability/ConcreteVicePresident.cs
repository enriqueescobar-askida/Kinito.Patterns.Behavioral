namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete vice president.
    /// </summary>
    public class ConcreteVicePresident : AbstractApprover
    {
        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="purchase">
        /// The purchase.
        /// </param>
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            else if (this.Successor != null)
                this.Successor.ProcessRequest(purchase);
        }
    }
}
