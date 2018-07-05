namespace Memento
{
    using System;

    /// <summary>
    /// The sales prospect.
    /// </summary>
    public class SalesProspect
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.Name;
            }

            set
            {
                this.Name = value;
                Console.WriteLine("Name:  " + this.Name);
            }
        }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone
        {
            get
            {
                return this.Phone;
            }

            set
            {
                this.Phone = value;
                Console.WriteLine("Phone: " + this.Phone);
            }
        }

        /// <summary>
        /// Gets or sets the budget.
        /// </summary>
        public double Budget
        {
            get
            {
                return this.Budget;
            }

            set
            {
                this.Budget = value;
                Console.WriteLine("Budget: " + this.Budget);
            }
        }

        /// <summary>
        /// The save memento.
        /// </summary>
        /// <returns>
        /// The <see cref="Memento"/>.
        /// </returns>
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(this.Name, this.Phone, this.Budget);
        }

        /// <summary>
        /// The restore memento.
        /// </summary>
        /// <param name="memento">
        /// The memento.
        /// </param>
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }
}