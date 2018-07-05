namespace Observer
{
    using System;

    /// <summary>
    /// The value average observer.
    /// </summary>
    public class ValueAverageObserver
    {
        public ValueAverageObserver(MyValue t)
        {
            t.ValueChanged += this.ValueChange;
        }

        /// <summary>
        /// Values the change.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="temp">The <see cref="E4SS.DesignPattern.Behav.Observer.ValueChangedEventArgs"/> instance containing the event data.</param>
        public void ValueChange(Object sender, ValueChangedEventArgs temp)
        {
            this.Count++;
            this.Sum += temp.NewValue;
            Console.WriteLine("AverageObserver: Average={0:F}", (double)this.Sum / (double)this.Count);
        }

        /// <summary>
        /// Gets the sum.
        /// </summary>
        public int Sum { get; internal set; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        public int Count { get; internal set; }
    }
}