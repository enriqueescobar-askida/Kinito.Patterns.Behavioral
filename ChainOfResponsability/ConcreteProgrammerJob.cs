namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete programmer job.
    /// </summary>
    public class ConcreteProgrammerJob : AbstractProgrammerJob
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
                case "Code":
                    Console.WriteLine("{0} has managed the code.", this);
                    break;
                default:
                    if (this.NextJob != null)
                        this.NextJob.DealWithRequirement(requirement);
                    break;
            }
        }
    }
}
