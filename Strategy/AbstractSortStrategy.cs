namespace Strategy
{
    using System.Collections.Generic;

    /// <summary>
    /// The abstract sort strategy.
    /// </summary>
    public abstract class AbstractSortStrategy
    {
        /// <summary>
        /// The sort.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public abstract void Sort(List<string> list);
    }
}