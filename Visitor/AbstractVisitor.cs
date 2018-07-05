/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class AbstractVisitor.
    /// </summary>
    public abstract class AbstractVisitor
    {
        //public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        /// <summary>
        /// Visits the aggregate concrete elementito.
        /// </summary>
        /// <param name="aConcreteElementito">The aggregate concrete elementito.</param>
        public abstract void VisitAConcreteElementito(AConcreteElementito aConcreteElementito);

        //public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
        /// <summary>
        /// Visits another concrete elemetito.
        /// </summary>
        /// <param name="anotherConcreteElementito">Another concrete elementito.</param>
        public abstract void VisitAnotherConcreteElemetito(AnotherConcreteElementito anotherConcreteElementito);
    }
}
