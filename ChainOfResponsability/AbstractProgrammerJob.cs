namespace ChainOfResponsability
{
    /// <summary>
    /// The abstract programmer job.
    /// </summary>
    public abstract class AbstractProgrammerJob
    {
        /// <summary>
        /// The next in chain.
        /// </summary>
        /// <param name="next">
        /// The next.
        /// </param>
        public void NextInChain(AbstractProgrammerJob next)
        {
            this.NextJob = next;
        }

        /// <summary>
        /// The deal with requirement.
        /// </summary>
        /// <param name="requirement">
        /// The requirement.
        /// </param>
        public abstract void DealWithRequirement(string requirement);

        /// <summary>
        /// Gets the next job.
        /// </summary>
        public AbstractProgrammerJob NextJob { get; internal set; }
    }
}