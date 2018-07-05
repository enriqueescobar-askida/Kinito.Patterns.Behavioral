/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class AbstractElementito.
    /// </summary>
    public abstract class AbstractElementito
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(AbstractVisitor abstractVisitor);
    }
}
