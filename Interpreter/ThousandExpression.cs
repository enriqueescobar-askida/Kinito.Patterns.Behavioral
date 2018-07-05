namespace Interpreter
{
    /// <summary>
    /// The thousand expression.
    /// </summary>
    public class ThousandExpression : AnAbstractExpression
    {
        /// <summary>
        /// The one.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string One()
        {
            return "M";
        }

        /// <summary>
        /// The four.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Four()
        {
            return " ";
        }

        /// <summary>
        /// The five.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Five()
        {
            return " ";
        }

        /// <summary>
        /// The nine.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Nine()
        {
            return " ";
        }

        /// <summary>
        /// The multiplier.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int Multiplier()
        {
            return 1000;
        }
    }
}