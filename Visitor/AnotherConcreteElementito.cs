/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class AnotherConcreteElementito.
    /// </summary>
    public class AnotherConcreteElementito : AbstractElementito
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="abstractVisitor">The visitor.</param>
        public override void Accept(AbstractVisitor abstractVisitor)
        {
            //visitor.VisitConcreteElementB(this);
            abstractVisitor.VisitAnotherConcreteElemetito(this);
        }

        /// <summary>
        /// Anothers the operation.
        /// </summary>
        public void AnotherOperation()
        {
        }
    }
}
