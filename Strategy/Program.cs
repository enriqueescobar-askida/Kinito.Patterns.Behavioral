namespace Strategy
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            TestFirst();
            TestSecond();
            TestThird();
        }

        /// <summary>
        /// The test third.
        /// </summary>
        private static void TestThird()
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samuel");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivie");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            
            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            // Three contexts following different strategies
            AnotherContext anotherContext = new AnotherContext(new AnotherStrategyA());
            anotherContext.ContextInterface();
            anotherContext = new AnotherContext(new AnotherStrategyB());
            anotherContext.ContextInterface();
            anotherContext = new AnotherContext(new AnotherStrategyC());
            anotherContext.ContextInterface();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            CreditSalesContext creditSalesContext = new CreditSalesContext(new CorporateStrategy());
            creditSalesContext.BusinessRule();
        }
    }
}