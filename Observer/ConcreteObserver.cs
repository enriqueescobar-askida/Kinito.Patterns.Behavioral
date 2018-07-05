namespace Observer
{
    using System;

    /// <summary>
    /// The concrete observer.
    /// </summary>
    public class ConcreteObserver : AbstractObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public ConcreteSubject Subject { get; set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the observer state.
        /// </summary>
        public string ObserverState { get; internal set; }

        /// <summary>
        /// The update.
        /// </summary>
        public override void Update()
        {
            this.ObserverState = this.Subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", this.Name, this.ObserverState);
        }
    }
}