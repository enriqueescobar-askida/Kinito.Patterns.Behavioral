namespace Interpreter
{
    /// <summary>
    /// The ten expression.
    /// </summary>
    public class TenExpression : AnAbstractExpression
    {
        /// <summary>
        /// The one.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string One()
        {
            return "X";
        }

        /// <summary>
        /// The four.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Four()
        {
            return "XL";
        }

        /// <summary>
        /// The five.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Five()
        {
            return "L";
        }

        /// <summary>
        /// The nine.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string Nine()
        {
            return "XC";
        }

        /// <summary>
        /// The multiplier.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int Multiplier()
        {
            return 10;
        }
    }
}
