namespace Interpreter
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

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
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            const string Roman = "MCMXXVIII";
            SecondContext context = new SecondContext(Roman);

            // Build the 'parse tree'
            List<AnAbstractExpression> tree = new List<AnAbstractExpression>
                                                  {
                                                      new ThousandExpression(),
                                                      new HundredExpression(),
                                                      new TenExpression(),
                                                      new OneExpression()
                                                  };

            // Interpret
            foreach (AnAbstractExpression anAbstractExpression in tree)
                anAbstractExpression.Interpret(context);
            
            Console.WriteLine("{0} = {1}", Roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            FirstContext firstContext = new FirstContext();

            // Usually a tree
            ArrayList arrayList = new ArrayList
                                      {
                                          new TerminalExpression(),
                                          new NonTerminalExpression(),
                                          new TerminalExpression(),
                                          new TerminalExpression()
                                      };

            // Populate 'abstract syntax tree'

            // Interpret
            foreach (AbstractExpression abstractExpression in arrayList)
                abstractExpression.Interpret(firstContext);

            // Wait for user
            Console.ReadKey();
        }
    }
}