/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class AnotherConcreteVisitor.
    /// </summary>
    public class AnotherConcreteVisitor : AbstractVisitor
    {
        /*public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }*/

        /// <summary>
        /// Visits the aggregate concrete elementito.
        /// </summary>
        /// <param name="aConcreteElementito">The aggregate concrete elementito.</param>
        public override void VisitAConcreteElementito(AConcreteElementito aConcreteElementito)
        {
            string s = aConcreteElementito.GetType().Name + " visited by " + this.GetType().Name;
        }

        /// <summary>
        /// Visits another concrete elemetito.
        /// </summary>
        /// <param name="anotherConcreteElementito">Another concrete elementito.</param>
        public override void VisitAnotherConcreteElemetito(AnotherConcreteElementito anotherConcreteElementito)
        {
            string s = anotherConcreteElementito.GetType().Name + " visited by " + this.GetType().Name;
        }
    }
}
