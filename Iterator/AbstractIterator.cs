namespace Iterator
{
    /// <summary>
    /// The abstract iterator.
    /// </summary>
    public abstract class AbstractIterator
    {
        /// <summary>
        /// The first.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public abstract object First();

        /// <summary>
        /// The next.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public abstract object Next();

        /// <summary>
        /// The is done.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public abstract bool IsDone();

        /// <summary>
        /// The current item.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public abstract object CurrentItem();
    }
}