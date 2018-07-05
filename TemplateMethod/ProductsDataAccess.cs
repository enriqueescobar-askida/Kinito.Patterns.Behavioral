namespace TemplateMethod
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// The products data access.
    /// </summary>
    public sealed class ProductsDataAccess : AbstractDataAccess
    {
        /// <summary>
        /// The select.
        /// </summary>
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, this.ConnectionString);
            this.DataSet = new DataSet();
            dataAdapter.Fill(this.DataSet, "Products");
        }

        /// <summary>
        /// The process.
        /// </summary>
        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = this.DataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows) Console.WriteLine(row["ProductName"]);

            Console.WriteLine();
        }
    }
}