/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class AConcreteElementito.
    /// </summary>
    public class AConcreteElementito : AbstractElementito
    {
        public override void Accept(AbstractVisitor abstractVisitor)
        {
            //visitor.VisitConcreteElementA(this);
            abstractVisitor.VisitAConcreteElementito(this);
        }

        /// <summary>
        /// Languages the operation.
        /// </summary>
        public void AnOperation()
        {
        }
    }
}
