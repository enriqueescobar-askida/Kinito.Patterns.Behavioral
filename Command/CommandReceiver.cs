using System;

namespace E4SS.DesignPattern.Behav.Command
{
    /// <summary>
    ///
    /// </summary>
    public class CommandReceiver
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandReceiver"/> class.
        /// </summary>
        public CommandReceiver()
        {
        }

        #endregion Constructors

        #region Destructor

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="CommandReceiver"/> is reclaimed by garbage collection.
        /// </summary>
        ~CommandReceiver()
        {
        }

        #endregion Destructor

        #region MethodMembers

        #region PublicMethods

        /// <summary>
        /// Actions this instance.
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Action Called ...");
        }

        #endregion PublicMethods

        #endregion MethodMembers
    }
}