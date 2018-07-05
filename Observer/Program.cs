namespace Observer
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
            TestForth();
        }

        /// <summary>
        /// The test forth.
        /// </summary>
        private static void TestForth()
        {
            // Create IBM stock and attach investors
            IbmStock ibmStock = new IbmStock("IBM", 120.00);
            ibmStock.Attach(new Investor("Sorrows"));
            ibmStock.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibmStock.Price = 120.10;
            ibmStock.Price = 121.00;
            ibmStock.Price = 120.50;
            ibmStock.Price = 120.75;

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test third.
        /// </summary>
        private static void TestThird()
        {
            // Configure Observer pattern
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            // Change subject and notify observers
            subject.SubjectState = "ABC";
            subject.Notify();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            MyValue myValue = new MyValue();
            new ValueChangeObserver(myValue);
            new ValueAverageObserver(myValue);
            myValue.Value = 100;
            myValue.Value = 99;
            myValue.Value = 88;
            myValue.Value = 77;
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            Subject subject = new Subject();
            ObjectObserver observerA = new ObjectObserver("A Observer");
            ObjectObserver observerB = new ObjectObserver("B Observer");

            observerA.ObservedObject = subject;
            observerB.ObservedObject = subject;

            observerA.Attach();
            observerB.Attach();
            subject.InterestingData = "# 001 is now finished!";

            observerA.Attach();
            subject.InterestingData = "# 002 is now finished!";
        }
    }
}