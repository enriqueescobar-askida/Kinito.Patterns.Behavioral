/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class ConcreteEmployees.
    /// </summary>
    public class ConcreteEmployees
    {
        /// <summary>
        /// The _concrete employees
        /// </summary>
        private List<ConcreteEmployee> _concreteEmployees = new List<ConcreteEmployee>();

        /// <summary>
        /// Attaches the specified concrete employee.
        /// </summary>
        /// <param name="concreteEmployee">The concrete employee.</param>
        public void Attach(ConcreteEmployee concreteEmployee)
        {
            this._concreteEmployees.Add(concreteEmployee);
        }

        /// <summary>
        /// Detaches the specified concrete employee.
        /// </summary>
        /// <param name="concreteEmployee">The concrete employee.</param>
        public void Detach(ConcreteEmployee concreteEmployee)
        {
            this._concreteEmployees.Remove(concreteEmployee);
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(IVisitor visitor)
        {
            foreach(ConcreteEmployee concreteEmployee in this._concreteEmployees)
            {
                concreteEmployee.Accept(visitor);
            }
        }
    }
}
