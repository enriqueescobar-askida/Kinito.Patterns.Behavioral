namespace Iterator
{
    /// <summary>
    /// The iterator.
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Iterator"/> class.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        public Iterator(Collection collection)
        {
            this.Collection = collection;
            this.Current = 0;
            this.Step = 0;
        }

        /// <summary>
        /// Gets the current item.
        /// </summary>
        public Item CurrentItem
        {
            get { return this.Collection[this.Current] as Item; }
        }

        /// <summary>
        /// Gets the collection.
        /// </summary>
        public Collection Collection { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether is done.
        /// </summary>
        public bool IsDone
        {
            get { return this.Current >= this.Collection.Count; }
        }

        /// <summary>
        /// Gets the current.
        /// </summary>
        public int Current { get; internal set; }

        /// <summary>
        /// Gets the step.
        /// </summary>
        public int Step { get; internal set; }

        /// <summary>
        /// The first.
        /// </summary>
        /// <returns>
        /// The <see cref="Item"/>.
        /// </returns>
        public Item First()
        {
            this.Current = 0;

            return this.Collection[this.Current] as Item;
        }

        /// <summary>
        /// The next.
        /// </summary>
        /// <returns>
        /// The <see cref="Item"/>.
        /// </returns>
        public Item Next()
        {
            this.Current += this.Step;

            if (!this.IsDone)
                return this.Collection[this.Current] as Item;
            else
                return null;
        }
    }
}