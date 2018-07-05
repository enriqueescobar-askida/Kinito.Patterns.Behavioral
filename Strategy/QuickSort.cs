namespace Strategy
{
    using System;

    /// <summary>
    /// The quick sort.
    /// </summary>
    public class QuickSort : AbstractSortStrategy
    {
        /// <summary>
        /// The sort.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public override void Sort(System.Collections.Generic.List<string> list)
        {
            list.Sort(); // Default is Quick sort
            Console.WriteLine("QuickSorted list ");
        }
    }
}