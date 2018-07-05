namespace State
{
    /// <summary>
    /// The abstract state.
    /// </summary>
    public abstract class AbstractState
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public abstract void Handle(Context context);
    }
}