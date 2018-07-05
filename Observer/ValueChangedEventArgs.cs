namespace Observer
{
    using System;

    /// <summary>
    /// The value changed event args.
    /// </summary>
    public class ValueChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueChangedEventArgs"/> class.
        /// </summary>
        /// <param name="oldTemp">
        /// The old temp.
        /// </param>
        /// <param name="newTemp">
        /// The new temp.
        /// </param>
        public ValueChangedEventArgs(int oldTemp, int newTemp)
        {
            this.OldValue = oldTemp;
            this.NewValue = newTemp;
        }

        /// <summary>
        /// Gets the old value.
        /// </summary>
        public int OldValue { get; internal set; }

        /// <summary>
        /// Gets the new value.
        /// </summary>
        public int NewValue { get; internal set; }
    }
}