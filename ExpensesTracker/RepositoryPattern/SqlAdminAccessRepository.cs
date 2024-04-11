using ExpensesTracker.RepositoryPattern.Interfaces;
using System.Data.SqlClient;

namespace ExpensesTracker.Repositories
{
    public class SqlAdminAccessRepository : IAdminAccessRepository
    {
        private readonly SqlConnection _sqlConnection;

        public SqlAdminAccessRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void AddAdmin(string username, string password)
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AdminAccess (AdminUsername, AdminPassword) VALUES (@username, @password)", _sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public bool ValidateAdminCredentials(string username, string password)
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM AdminAccess WHERE AdminUsername = @username AND AdminPassword = @password", _sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            int count = (int)command.ExecuteScalar();

            _sqlConnection.Close();

            // If count is 1, user credentials are valid
            // otherwise, they are invalid
            return count == 1;
        }

    }
}
