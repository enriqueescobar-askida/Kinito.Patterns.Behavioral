namespace Strategy
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The sorted list.
    /// </summary>
    public class SortedList
    {
        /// <summary>
        /// Gets the string list.
        /// </summary>
        public List<string> StringList { get; internal set; }

        /// <summary>
        /// Gets the sort strategy.
        /// </summary>
        public AbstractSortStrategy SortStrategy { get; internal set; }

        /// <summary>
        /// The set sort strategy.
        /// </summary>
        /// <param name="sortStrategy">
        /// The sort strategy.
        /// </param>
        public void SetSortStrategy(AbstractSortStrategy sortStrategy)
        {
            this.SortStrategy = sortStrategy;
        }

        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void Add(string name)
        {
            this.StringList.Add(name);
        }

        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public void Sort()
        {
            this.SortStrategy.Sort(this.StringList);

            // Iterate over list and display results
            foreach (string name in StringList) Console.WriteLine(" " + name);
        }
    }
}