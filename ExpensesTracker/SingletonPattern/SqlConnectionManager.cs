using System;
using System.Data.SqlClient;

namespace ExpensesTracker.Repositories
{
    public sealed class SqlConnectionManager
    {
        private static readonly SqlConnection _sqlConnection = new SqlConnection(@"Data Source=ST-ASUS;Initial Catalog=ExpensesDb;Integrated Security=True");

        // Private constructor to prevent instantiation from outside
        private SqlConnectionManager() { }

        // Property to access the singleton instance
        public static SqlConnection Instance => _sqlConnection;

        // Optional method to open the connection
        public static void OpenConnection()
        {
            if (_sqlConnection.State != System.Data.ConnectionState.Open)
            {
                _sqlConnection.Open();
            }
        }

        // Optional method to close the connection
        public static void CloseConnection()
        {
            if (_sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Close();
            }
        }
    }
}