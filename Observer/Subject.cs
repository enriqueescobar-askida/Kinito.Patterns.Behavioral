namespace Observer
{
    using System;

    /// <summary>
    /// The subject.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// The data.
        /// </summary>
        private string data;

        /// <summary>
        /// The changed.
        /// </summary>
        public event ChangedEventHandler Changed;

        /// <summary>
        /// Gets or sets the interesting data.
        /// </summary>
        public string InterestingData
        {
            get
            {
                return this.data;
            }

            set
            {
                this.data = value;
                this.OnChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// The on changed.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected virtual void OnChanged(EventArgs e)
        {
            if (this.Changed != null)
                this.Changed(this, e);
        }
    }
}