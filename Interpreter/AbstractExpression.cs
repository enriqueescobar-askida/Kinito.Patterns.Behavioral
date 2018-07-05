namespace Interpreter
{
    /// <summary>
    /// The abstract expression.
    /// </summary>
    public abstract class AbstractExpression
    {
        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public abstract void Interpret(FirstContext context);
    }
}
