namespace Iterator
{
    /// <summary>
    /// The AbstractIterator interface.
    /// </summary>
    public interface IAbstractIterator
    {
        /// <summary>
        /// Gets a value indicating whether is done.
        /// </summary>
        bool IsDone { get; }

        /// <summary>
        /// Gets the current item.
        /// </summary>
        Item CurrentItem { get; }

        /// <summary>
        /// The first.
        /// </summary>
        /// <returns>
        /// The <see cref="Item"/>.
        /// </returns>
        Item First();

        /// <summary>
        /// The next.
        /// </summary>
        /// <returns>
        /// The <see cref="Item"/>.
        /// </returns>
        Item Next();
    }
}