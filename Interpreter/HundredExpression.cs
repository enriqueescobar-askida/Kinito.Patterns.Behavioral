namespace Interpreter
{
    /// <summary>
    /// The hundred expression.
    /// </summary>
    public class HundredExpression : AnAbstractExpression
    {
        /// <summary>
        /// The one.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string One()
        {
            return "C";
        }

        /// <summary>
        /// The four.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Four()
        {
            return "CD";
        }

        /// <summary>
        /// The five.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Five()
        {
            return "D";
        }

        /// <summary>
        /// The nine.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Nine()
        {
            return "CM";
        }

        /// <summary>
        /// The multiplier.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int Multiplier()
        {
            return 100;
        }
    }
}
