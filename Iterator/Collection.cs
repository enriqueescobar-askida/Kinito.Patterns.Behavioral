namespace Iterator
{
    using System.Collections;

    /// <summary>
    /// The collection.
    /// </summary>
    public class Collection : IAbstractCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Collection"/> class.
        /// </summary>
        public Collection()
        {
            this.ItemList = new ArrayList();
        }

        /// <summary>
        /// Gets the item list.
        /// </summary>
        public ArrayList ItemList { get; internal set; }

        /// <summary>
        /// The create iterator.
        /// </summary>
        /// <returns>
        /// The <see cref="Iterator"/>.
        /// </returns>
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        public int Count
        {
            get { return this.ItemList.Count; }
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
            set { this.ItemList.Add(value); }
        }
    }
}