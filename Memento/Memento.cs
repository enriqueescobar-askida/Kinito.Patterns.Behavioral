namespace Memento
{
    /// <summary>
    /// The memento.
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Memento"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="phone">
        /// The phone.
        /// </param>
        /// <param name="budget">
        /// The budget.
        /// </param>
        public Memento(string name, string phone, double budget)
        {
            this.Name = name;
            this.Phone = phone;
            this.Budget = budget;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the phone.
        /// </summary>
        public string Phone { get; internal set; }

        /// <summary>
        /// Gets the budget.
        /// </summary>
        public double Budget { get; internal set; }
    }
}