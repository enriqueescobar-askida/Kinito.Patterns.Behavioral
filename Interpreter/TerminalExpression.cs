namespace Interpreter
{
    using System;

    /// <summary>
    /// The terminal expression.
    /// </summary>
    public class TerminalExpression : AbstractExpression
    {
        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Interpret(FirstContext context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}
