namespace Command
{
    using System;

    /// <summary>
    /// The calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Gets the current.
        /// </summary>
        public int Current { get; internal set; }

        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="operator">
        /// The operator.
        /// </param>
        /// <param name="operand">
        /// The operand.
        /// </param>
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    this.Current += operand;
                    break;
                case '-':
                    this.Current -= operand;
                    break;
                case '*':
                    this.Current *= operand;
                    break;
                case '/':
                    this.Current /= operand;
                    break;
            }
            Console.WriteLine("Current value = {0,3} (following {1} {2})",
              this.Current, @operator, operand);
        }
    }
}
