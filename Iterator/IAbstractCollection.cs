namespace Iterator
{
    /// <summary>
    /// The AbstractCollection interface.
    /// </summary>
    public interface IAbstractCollection
    {
        /// <summary>
        /// The create iterator.
        /// </summary>
        /// <returns>
        /// The <see cref="Iterator"/>.
        /// </returns>
        Iterator CreateIterator();
    }
}