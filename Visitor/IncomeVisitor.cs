/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class IncomeVisitor.
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="abstractElement">The abstract element.</param>
        public void Visit(AbstractElement abstractElement)
        {
            ConcreteEmployee concreteEmployee = abstractElement as ConcreteEmployee;

            if (concreteEmployee != null)
            {
                concreteEmployee.Income *= 1.10;
                /*Console.WriteLine("{0} {1}'s new income: {2:C}",
                    concreteEmployee.GetType().Name,
                    concreteEmployee.Name,
                    concreteEmployee.Income);*/
            }
        }
    }
}
