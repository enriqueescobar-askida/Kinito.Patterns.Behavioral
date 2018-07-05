namespace Observer
{
    using System;

    /// <summary>
    /// The object observer.
    /// </summary>
    public class ObjectObserver
    {
        /// <summary>
        /// Gets the observer name.
        /// </summary>
        public string ObserverName { get; internal set; }

        /// <summary>
        /// Gets the subject.
        /// </summary>
        public Subject DataSubject { get; internal set; }

        /// <summary>
        /// Gets or sets the observed object.
        /// </summary>
        public Subject ObservedObject
        {
            get
            {
                return this.DataSubject;
            }

            set
            {
                this.DataSubject = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectObserver"/> class.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        public ObjectObserver(string p)
        {
            this.ObserverName = p;
        }

        /// <summary>
        /// The data changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DataChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.ObserverName);
            Console.WriteLine(this.DataSubject.InterestingData);
        }

        /// <summary>
        /// Attaches this instance.
        /// </summary>
        public void Attach()
        {
            this.DataSubject.Changed += new ChangedEventHandler(this.DataChanged);
        }

        /// <summary>
        /// Detaches this instance.
        /// </summary>
        public void Detach()
        {
            this.DataSubject.Changed -= new ChangedEventHandler(this.DataChanged);
        }
    }
}
