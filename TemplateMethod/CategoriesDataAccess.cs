namespace TemplateMethod
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// The categories data access.
    /// </summary>
    public sealed class CategoriesDataAccess : AbstractDataAccess
    {
        /// <summary>
        /// The select.
        /// </summary>
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, this.ConnectionString);
            this.DataSet = new DataSet();
            dataAdapter.Fill(this.DataSet, "Categories");
        }

        /// <summary>
        /// The process.
        /// </summary>
        public override void Process()
        {
            Console.WriteLine("Categories ---- ");
            DataTable dataTable = this.DataSet.Tables["Categories"];

            foreach (DataRow row in dataTable.Rows) Console.WriteLine(row["CategoryName"]);

            Console.WriteLine();
        }
    }
}