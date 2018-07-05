/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class Director.
    /// </summary>
    public class Director : ConcreteEmployee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Director"/> class.
        /// </summary>
        public Director()
            : base("Elly", 35000.0, 16)
        { }
    }
}
