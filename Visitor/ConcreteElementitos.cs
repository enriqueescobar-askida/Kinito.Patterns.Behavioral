/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    using System.Collections.Generic;

    /// <summary>
    /// Class ConcreteElementitos.
    /// </summary>
    public class ConcreteElementitos
    {
        /// <summary>
        /// The _elementitos
        /// </summary>
        private readonly List<AbstractElementito> _abstractElementitos = new List<AbstractElementito>();

        /// <summary>
        /// Attaches the specified elementito.
        /// </summary>
        /// <param name="abstractElementito">The elementito.</param>
        public void Attach(AbstractElementito abstractElementito)
        {
            this._abstractElementitos.Add(abstractElementito);
        }

        /// <summary>
        /// Detaches the specified elementito.
        /// </summary>
        /// <param name="abstractElementito">The elementito.</param>
        public void Detach(AbstractElementito abstractElementito)
        {
            this._abstractElementitos.Remove(abstractElementito);
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="abstarctVisitor">The visitor.</param>
        public void Accept(AbstractVisitor abstarctVisitor)
        {
            foreach (AbstractElementito elementito in this._abstractElementitos)
            {
                elementito.Accept(abstarctVisitor);
            }
        }
    }
}
