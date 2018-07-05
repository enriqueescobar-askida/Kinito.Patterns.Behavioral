namespace ChainOfResponsability
{
    using System;

    /// <summary>
    /// The concrete staff job.
    /// </summary>
    public class ConcreteStaffJob : AbstractProgrammerJob
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
                case "Test":
                    Console.WriteLine("{0} has managed the test.", this);
                    break;
                default:
                    if (this.NextJob != null)
                        this.NextJob.DealWithRequirement(requirement);
                    break;
            }
        }
    }
}
