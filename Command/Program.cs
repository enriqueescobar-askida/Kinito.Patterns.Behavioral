namespace Command
{
    using System;

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
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            // Create receiver, command, and invoker
            AbstractCommand command = new ConcreteCommand(new Receiver());
            Invoker invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Wait for user
            Console.ReadKey();
        }
    }
}