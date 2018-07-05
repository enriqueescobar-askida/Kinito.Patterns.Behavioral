namespace Strategy
{
    using System;

    /// <summary>
    /// The another strategy a.
    /// </summary>
    public class AnotherStrategyA : AnotherAbstractStrategy
    {
        /// <summary>
        /// The algorithm interface.
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called AnotherStrategyA.AlgorithmInterface()");
        }
    }
}