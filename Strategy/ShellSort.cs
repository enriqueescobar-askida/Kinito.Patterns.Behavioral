namespace Strategy
{
    using System;

    /// <summary>
    /// The shell sort.
    /// </summary>
    public class ShellSort : AbstractSortStrategy
    {
        /// <summary>
        /// The sort.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public override void Sort(System.Collections.Generic.List<string> list)
        {
            // list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}