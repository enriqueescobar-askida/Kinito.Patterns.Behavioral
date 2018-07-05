/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    using System;

    /// <summary>
    /// Class VacationVisitor.
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="abstractElement">The abstract element.</param>
        public void Visit(AbstractElement abstractElement)
        {
            ConcreteEmployee concreteEmployee = abstractElement as ConcreteEmployee;
            if (concreteEmployee == null) throw new NotImplementedException();
            //Console.WriteLine("{0} {1}'s new vacation days: {2}", concreteEmployee.GetType().Name, concreteEmployee.Name, concreteEmployee.VacationDays);
        }
    }
}
