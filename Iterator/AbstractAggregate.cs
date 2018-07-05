namespace Iterator
{
    /// <summary>
    /// The abstract aggregate.
    /// </summary>
    public abstract class AbstractAggregate
    {
        /// <summary>
        /// The create iterator.
        /// </summary>
        /// <returns>
        /// The <see cref="AbstractIterator"/>.
        /// </returns>
        public abstract AbstractIterator CreateIterator();
    }
}