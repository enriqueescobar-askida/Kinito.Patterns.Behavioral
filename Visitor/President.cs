/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class President.
    /// </summary>
    public class President : ConcreteEmployee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="President"/> class.
        /// </summary>
        public President()
            : base("Dick", 45000.0, 21)
        {
        }
    }
}
