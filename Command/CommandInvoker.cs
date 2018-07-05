namespace E4SS.DesignPattern.Behav.Command
{
    /// <summary>
    ///
    /// </summary>
    public class CommandInvoker
    {
        #region AttributeMembers

        #region PrivateAttributes

        /// <summary>
        ///
        /// </summary>
        private ConcreteCommand _command;

        #endregion PrivateAttributes

        #endregion AttributeMembers

        #region AttributeAccessors

        #region Setters

        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="command">The command.</param>
        public void SetCommand(ConcreteCommand command)
        {
            this._command = command;
        }

        #endregion Setters

        #endregion AttributeAccessors

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandInvoker"/> class.
        /// </summary>
        public CommandInvoker()
        {
        }

        #endregion Constructors

        #region Destructor

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="CommandInvoker"/> is reclaimed by garbage collection.
        /// </summary>
        ~CommandInvoker()
        {
        }

        #endregion Destructor

        #region MethodMembers

        #region PublicMethods

        /// <summary>
        /// Executes the command.
        /// </summary>
        public void ExecuteCommand()
        {
            this._command.Execute();
        }

        #endregion PublicMethods

        #endregion MethodMembers
    }
}