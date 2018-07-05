namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete handler 1.
    /// </summary>
    public class ConcreteHandler1 : AbstractHandler
    {
        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            else if (this.Successor != null)
                this.Successor.HandleRequest(request);
        }
    }
}
