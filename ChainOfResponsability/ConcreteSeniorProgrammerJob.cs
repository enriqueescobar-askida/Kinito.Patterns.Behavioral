namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete senior programmer job.
    /// </summary>
    public class ConcreteSeniorProgrammerJob : AbstractProgrammerJob
    {
        /// <summary>
        /// The deal with requirement.
        /// </summary>
        /// <param name="requirement">
        /// The requirement.
        /// </param>
        public override void DealWithRequirement(string requirement)
        {
            switch (requirement)
            {
                default:
                    Console.WriteLine("{0} has managed the " + requirement + " requirement.", this);
                    break;
            }
        }
    }
}
