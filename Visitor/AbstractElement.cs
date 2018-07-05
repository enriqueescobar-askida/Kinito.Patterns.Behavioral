/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class AbstractElement.
    /// </summary>
    public abstract class AbstractElement
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(IVisitor visitor);
    }
}
