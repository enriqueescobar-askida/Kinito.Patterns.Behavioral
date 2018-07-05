namespace Interpreter
{
    /// <summary>
    /// The one expression.
    /// </summary>
    public class OneExpression : AnAbstractExpression
    {
        /// <summary>
        /// The one.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string One()
        {
            return "I";
        }

        /// <summary>
        /// The four.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Four()
        {
            return "IV";
        }

        /// <summary>
        /// The five.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Five()
        {
            return "V";
        }

        /// <summary>
        /// The nine.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Nine()
        {
            return "IX";
        }

        /// <summary>
        /// The multiplier.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int Multiplier()
        {
            return 1;
        }
    }
}
