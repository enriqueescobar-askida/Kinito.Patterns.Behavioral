namespace State
{
    /// <summary>
    /// The concrete state a.
    /// </summary>
    public class ConcreteStateA : AbstractState
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}