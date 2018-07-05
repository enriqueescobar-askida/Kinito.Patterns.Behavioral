namespace TemplateMethod
{
    using System.Data;

    /// <summary>
    /// The abstract data access.
    /// </summary>
    public abstract class AbstractDataAccess
    {
        /// <summary>
        /// Gets the connection string.
        /// </summary>
        public string ConnectionString { get; internal set; }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        public DataSet DataSet { get; internal set; }

        /// <summary>
        /// The connect.
        /// </summary>
        public virtual void Connect()
        {
            // Make sure MDB is available to app
            this.ConnectionString = "provider=Microsoft.JET.OLEDB.4.0; " + "data source=..\\..\\db1.mdb";
        }

        /// <summary>
        /// The select.
        /// </summary>
        public abstract void Select();

        /// <summary>
        /// The process.
        /// </summary>
        public abstract void Process();

        /// <summary>
        /// The disconnect.
        /// </summary>
        public virtual void Disconnect()
        {
            this.ConnectionString = "";
        }

        /// <summary>
        /// The run.
        /// </summary>
        public void Run()
        {
            this.Connect();
            this.Select();
            this.Process();
            this.Disconnect();
        }
    }
}
