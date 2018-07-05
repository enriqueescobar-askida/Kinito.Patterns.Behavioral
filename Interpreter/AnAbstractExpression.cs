namespace Interpreter
{
    /// <summary>
    /// The an abstract expression.
    /// </summary>
    public abstract class AnAbstractExpression
    {
        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public void Interpret(SecondContext context)
        {
            if (context.Input.Length == 0)
                return;
            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
            while (context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }

        /// <summary>
        /// The one.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public abstract string One();

        /// <summary>
        /// The four.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public abstract string Four();

        /// <summary>
        /// The five.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public abstract string Five();

        /// <summary>
        /// The nine.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public abstract string Nine();

        /// <summary>
        /// The multiplier.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public abstract int Multiplier();
    }
}