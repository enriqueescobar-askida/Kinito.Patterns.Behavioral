﻿namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete handler 3.
    /// </summary>
    public class ConcreteHandler3 : AbstractHandler
    {
        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            else if (this.Successor != null)
                this.Successor.HandleRequest(request);
        }
    }
}
