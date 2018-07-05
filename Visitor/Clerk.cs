/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class Clerk.
    /// </summary>
    public class Clerk : ConcreteEmployee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clerk"/> class.
        /// </summary>
        public Clerk()
            : base("Hank", 25000.0, 14)
        {
        }
    }
}
