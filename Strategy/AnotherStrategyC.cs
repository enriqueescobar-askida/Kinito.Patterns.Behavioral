namespace Strategy
{
    using System;

    /// <summary>
    /// The another strategy c.
    /// </summary>
    public class AnotherStrategyC : AnotherAbstractStrategy
    {
        /// <summary>
        /// The algorithm interface.
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called AnotherStrategyC.AlgorithmInterface()");
        }
    }
}