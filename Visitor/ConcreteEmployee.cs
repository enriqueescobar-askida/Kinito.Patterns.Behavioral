/// <summary>
/// The Visitor namespace.
/// </summary>
namespace Visitor
{
    /// <summary>
    /// Class ConcreteEmployee.
    /// </summary>
    public class ConcreteEmployee : AbstractElement
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the income.
        /// </summary>
        /// <value>The income.</value>
        public double Income { get; set; }

        /// <summary>
        /// Gets or sets the vacation days.
        /// </summary>
        /// <value>The vacation days.</value>
        public int VacationDays { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteEmployee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="income">The income.</param>
        /// <param name="vacationDays">The vacation days.</param>
        public ConcreteEmployee(string name, double income, int vacationDays)
        {
            this.Name = name;
            this.Income = income;
            this.VacationDays = vacationDays;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Accept(IVisitor visitor)
        {
            if (visitor != null) visitor.Visit(this);
        }
    }
}
