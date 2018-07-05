namespace Interpreter
{
    /// <summary>
    /// The second context.
    /// </summary>
    public class SecondContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondContext"/> class.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        public SecondContext(string input)
        {
            this.Input = input;
        }

        /// <summary>
        /// Gets the output.
        /// </summary>
        public int Output { get; internal set; }

        /// <summary>
        /// Gets the input.
        /// </summary>
        public string Input { get; internal set; }
    }
}
