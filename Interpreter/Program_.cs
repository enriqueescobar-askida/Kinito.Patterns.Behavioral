using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Behav.Interpreter_
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman); 
            // Build the 'parse tree'
            List<AnAbstractExpression> tree = new List<AbstractExpression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression()); 
            // Interpret
            foreach (AbstractExpression exp in tree)
            {
                exp.Interpret(context);
            } 
            Console.WriteLine("{0} = {1}",
            roman, context.Output); 
            // Wait for user
            Console.ReadKey();
        }
    }
}
