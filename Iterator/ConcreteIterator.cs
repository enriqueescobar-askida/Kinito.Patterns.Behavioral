namespace Iterator
{
    /// <summary>
    /// The concrete iterator.
    /// </summary>
    public class ConcreteIterator : AbstractIterator
    {
        /// <summary>
        /// Gets the aggregate.
        /// </summary>
        public ConcreteAggregate Aggregate { get; internal set; }

        /// <summary>
        /// Gets the current.
        /// </summary>
        public int Current { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteIterator"/> class.
        /// </summary>
        /// <param name="aggregate">
        /// The aggregate.
        /// </param>
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.Aggregate = aggregate;
        }

        /// <summary>
        /// The first.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object First()
        {
            return this.Aggregate[0];
        }

        /// <summary>
        /// The next.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object Next()
        {
            object ret = null;
            if (this.Current < this.Aggregate.Count - 1)
            {
                ret = this.Aggregate[++this.Current];
            }

            return ret;
        }

        /// <summary>
        /// The is done.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool IsDone()
        {
            return this.Current >= this.Aggregate.Count;
        }

        /// <summary>
        /// The current item.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object CurrentItem()
        {
            return this.Aggregate[this.Current];
        }
    }
}