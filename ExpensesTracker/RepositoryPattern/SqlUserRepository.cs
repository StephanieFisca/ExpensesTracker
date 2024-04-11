using ExpensesTracker.RepositoryPattern.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;

namespace ExpensesTracker.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly SqlConnection _sqlConnection;

        public SqlUserRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public bool ValidateUserCredentials(string username, string password)
        {
            _sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE UName = @username AND UPassword = @password", _sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            int count = (int)command.ExecuteScalar();

            _sqlConnection.Close();

            return count == 1;
        }

        public User GetUserByUsername(string username)
        {
            _sqlConnection.Open();
            string query = "SELECT * FROM UserTbl WHERE UName=@username";
            SqlCommand command = new SqlCommand(query, _sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();

            User user = null;
            if (reader.Read())
            {
                // Assuming User class has properties corresponding to UserTbl columns
                user = new User
                {
                    // Populate user properties from reader
                };
            }

            reader.Close();
            _sqlConnection.Close();

            return user;
        }
        public void AddUser(string userName, DateTime dob, string phone, string password, string address)
        {
            _sqlConnection.Open();
            string query = "INSERT INTO UserTbl (UName, UDOB, Uphone, UPassword, UAddress) VALUES (@userName, @dob, @phone, @password, @address)";
            SqlCommand command = new SqlCommand(query, _sqlConnection);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@address", address);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public DataTable GetAllUsers()
        {
            DataTable usersTable = new DataTable();

            try
            {
                _sqlConnection.Open();

                string query = "SELECT * FROM UserTbl";
                SqlCommand command = new SqlCommand(query, _sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(usersTable);
            }
            catch (Exception ex)
            {
                // Handle the exception if needed
                Console.WriteLine($"Error occurred while fetching users: {ex.Message}");
            }
            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return usersTable;
        }

    }
}
