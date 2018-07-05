namespace Command
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets the calculator.
        /// </summary>
        public Calculator Calculator { get; internal set; }

        /// <summary>
        /// Gets the commands.
        /// </summary>
        public List<AnAbstractCommand> Commands { get; internal set; }

        /// <summary>
        /// Gets the current.
        /// </summary>
        public int Current { get; internal set; }

        /// <summary>
        /// The compute.
        /// </summary>
        /// <param name="operator">
        /// The operator.
        /// </param>
        /// <param name="operand">
        /// The operand.
        /// </param>
        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            AnAbstractCommand command = new CalculatorCommand(
              this.Calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            this.Commands.Add(command);
            this.Current++;
        }

        /// <summary>
        /// The undo.
        /// </summary>
        /// <param name="levels">
        /// The levels.
        /// </param>
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (this.Current > 0)
                {
                    AnAbstractCommand command = this.Commands[--this.Current] as AnAbstractCommand;
                    command.UnExecute();
                }
            }
        }

        /// <summary>
        /// The redo.
        /// </summary>
        /// <param name="levels">
        /// The levels.
        /// </param>
        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (this.Current < this.Commands.Count - 1)
                {
                    AnAbstractCommand command = this.Commands[this.Current++];
                    command.Execute();
                }
            }
        }
    }
}
