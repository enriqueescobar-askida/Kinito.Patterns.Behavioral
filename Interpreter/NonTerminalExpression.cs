namespace Interpreter
{
    using System;

    /// <summary>
    /// The non terminal expression.
    /// </summary>
    public class NonTerminalExpression : AbstractExpression
    {
        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Interpret(FirstContext context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}