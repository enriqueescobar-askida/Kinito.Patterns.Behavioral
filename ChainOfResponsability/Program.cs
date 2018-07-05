namespace ChainOfResponsability
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
        public static void Main()
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
            // Setup Chain of Responsibility
            AbstractHandler h1 = new ConcreteHandler1();
            AbstractHandler h2 = new ConcreteHandler2();
            AbstractHandler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);
            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
            foreach (int request in requests)
                h1.HandleRequest(request);

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            AbstractProgrammerJob staff = new ConcreteStaffJob();
            AbstractProgrammerJob manager = new ConcreteProgrammerJob();
            AbstractProgrammerJob seniorProgrammer = new ConcreteSeniorProgrammerJob();

            staff.NextInChain(manager);
            manager.NextInChain(seniorProgrammer);
            staff.DealWithRequirement("Plan");
            staff.DealWithRequirement("Test");
            staff.DealWithRequirement("Code");
            staff.DealWithRequirement("Deploy");
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            // Setup Chain of Responsibility
            AbstractApprover larry = new ConcreteDirector();
            AbstractApprover sam = new ConcreteVicePresident();
            AbstractApprover tammy = new ConcretePresident();
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase purchase = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(purchase);

            // Wait for user
            Console.ReadKey();
        }
    }
}