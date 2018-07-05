namespace Strategy
{
    using System;

    /// <summary>
    /// The another strategy b.
    /// </summary>
    public class AnotherStrategyB : AnotherAbstractStrategy
    {
        /// <summary>
        /// The algorithm interface.
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called AnotherStrategyB.AlgorithmInterface()");
        }
    }
}