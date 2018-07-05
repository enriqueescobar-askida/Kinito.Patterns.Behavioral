namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete director.
    /// </summary>
    public class ConcreteDirector : AbstractApprover
    {
        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="purchase">
        /// The purchase.
        /// </param>
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            else if (this.Successor != null)
                this.Successor.ProcessRequest(purchase);
        }
    }
}
