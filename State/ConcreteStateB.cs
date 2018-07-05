namespace State
{
    /// <summary>
    /// The concrete state b.
    /// </summary>
    public class ConcreteStateB : AbstractState
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}