namespace Strategy
{
    using System;

    /// <summary>
    /// The merge sort.
    /// </summary>
    public class MergeSort : AbstractSortStrategy
    {
        /// <summary>
        /// The sort.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public override void Sort(System.Collections.Generic.List<string> list)
        {
            // list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}