namespace Observer
{
    /// <summary>
    /// The my value.
    /// </summary>
    public class MyValue
    {
        /// <summary>
        /// The value changed.
        /// </summary>
        public event ValueChangedEventHandler ValueChanged;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value
        {
            get
            {
                return this.Myvalue;
            }

            set
            {
                ValueChangedEventArgs args = new ValueChangedEventArgs(this.Myvalue, value);
                this.Myvalue = value;
                this.OnValueChanged(args);
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Myvalue { get; set; }

        /// <summary>
        /// The on value changed.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        virtual protected void OnValueChanged(ValueChangedEventArgs args)
        {
            if (this.ValueChanged != null)
            {
                ValueChangedEventHandler onValueChanged = this.ValueChanged;
                if (onValueChanged != null)
                {
                    onValueChanged(this, args);
                }
            }
        }
    }
}
