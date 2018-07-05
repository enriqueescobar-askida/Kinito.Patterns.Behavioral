namespace Iterator
{
    using System.Collections;

    /// <summary>
    /// The concrete aggregate.
    /// </summary>
    public class ConcreteAggregate : AbstractAggregate
    {
        /// <summary>
        /// Gets the item list.
        /// </summary>
        public ArrayList ItemList { get; internal set; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        public int Count
        {
            get { return this.ItemList.Count; }
        }

        /// <summary>
        /// The create iterator.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractIterator"/>.
        /// </returns>
        public override AbstractIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        /// <summary>
        /// The this.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object this[int index]
        {
            get { return this.ItemList[index]; }
            set { this.ItemList.Insert(index, value); }
        }
    }
}