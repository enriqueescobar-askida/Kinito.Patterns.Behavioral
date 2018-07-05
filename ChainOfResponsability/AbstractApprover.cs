namespace ChainOfResponsability
{
    /// <summary>
    /// The abstract approver.
    /// </summary>
    public abstract class AbstractApprover
    {
        /// <summary>
        /// Gets the successor.
        /// </summary>
        public AbstractApprover Successor { get; internal set; }

        /// <summary>
        /// Sets the successor.
        /// </summary>
        /// <param name="successor">The successor.</param>
        public void SetSuccessor(AbstractApprover successor)
        {
            this.Successor = successor;
        }

        /// <summary>
        /// The process request.
        /// </summary>
        /// <param name="purchase">
        /// The purchase.
        /// </param>
        public abstract void ProcessRequest(Purchase purchase);
    }
}