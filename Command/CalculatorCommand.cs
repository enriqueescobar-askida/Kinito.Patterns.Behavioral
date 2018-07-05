namespace Command
{
    using System;

    /// <summary>
    /// The calculator command.
    /// </summary>
    public class CalculatorCommand : AnAbstractCommand
    {
        /// <summary>
        /// Gets the operator.
        /// </summary>
        public char Operator { get; internal set; }

        /// <summary>
        /// Gets the operand.
        /// </summary>
        public int Operand { get; internal set; }

        /// <summary>
        /// Gets the calculator.
        /// </summary>
        public Calculator Calculator { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorCommand"/> class.
        /// </summary>
        /// <param name="calculator">
        /// The calculator.
        /// </param>
        /// <param name="operator">
        /// The operator.
        /// </param>
        /// <param name="operand">
        /// The operand.
        /// </param>
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.Calculator = calculator;
            this.Operator = @operator;
            this.Operand = operand;
        }

        /// <summary>
        /// The undo.
        /// </summary>
        /// <param name="operator">
        /// The operator.
        /// </param>
        /// <returns>
        /// The <see cref="char"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        private static char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }

        /// <summary>
        /// The execute.
        /// </summary>
        public override void Execute()
        {
            this.Calculator.Operation(this.Operator, this.Operand);
        }

        /// <summary>
        /// The un execute.
        /// </summary>
        public override void UnExecute()
        {
            this.Calculator.Operation(Undo(this.Operator), this.Operand);
        }
    }
}