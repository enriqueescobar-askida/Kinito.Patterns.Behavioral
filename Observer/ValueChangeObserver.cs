namespace Observer
{
    using System;

    /// <summary>
    /// The value change observer.
    /// </summary>
    public class ValueChangeObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueChangeObserver"/> class.
        /// </summary>
        /// <param name="t">
        /// The t.
        /// </param>
        public ValueChangeObserver(MyValue t)
        {
            t.ValueChanged += this.ValueChange;
        }

        /// <summary>
        /// Values the change.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="temp">The <see cref="ValueChangedEventArgs"/> instance containing the event data.</param>
        public void ValueChange(Object sender, ValueChangedEventArgs temp)
        {
            Console.WriteLine("ChangeObserver: Old={0}, New={1}, Change={2}", temp.OldValue, temp.NewValue, temp.NewValue - temp.OldValue);
        }
    }
}