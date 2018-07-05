namespace Observer
{
    using System.Collections.Generic;

    /// <summary>
    /// The abstract subject.
    /// </summary>
    public abstract class AbstractSubject
    {
        /// <summary>
        /// Gets the observers.
        /// </summary>
        public List<AbstractObserver> Observers { get; internal set; }

        /// <summary>
        /// The attach.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void Attach(AbstractObserver observer)
        {
            this.Observers.Add(observer);
        }

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Detach(AbstractObserver observer)
        {
            this.Observers.Remove(observer);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (AbstractObserver o in this.Observers)
                o.Update();
        }
    }
}