namespace ChainOfResponsability
{
    /// <summary>
    /// The abstract handler.
    /// </summary>
    public abstract class AbstractHandler
    {
        /// <summary>
        /// The set successor.
        /// </summary>
        /// <param name="successor">
        /// The successor.
        /// </param>
        public void SetSuccessor(AbstractHandler successor)
        {
            this.Successor = successor;
        }

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        public abstract void HandleRequest(int request);

        /// <summary>
        /// Gets the successor.
        /// </summary>
        public AbstractHandler Successor { get; internal set; }
    }
}
