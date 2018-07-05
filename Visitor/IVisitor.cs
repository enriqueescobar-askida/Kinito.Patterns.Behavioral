/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Interface IVisitor
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The abstract element.</param>
        void Visit(AbstractElement abstractElement);
    }
}
