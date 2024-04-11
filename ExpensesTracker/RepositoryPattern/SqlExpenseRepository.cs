using ExpensesTracker.RepositoryPattern.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpensesTracker.Repositories
{
    public class SqlExpenseRepository : IExpenseRepository
    {
        private readonly SqlConnection _sqlConnection;
        private readonly IUserRepository _userRepository;

        public SqlExpenseRepository(SqlConnection sqlConnection, IUserRepository userRepository)
        {
            _sqlConnection = sqlConnection;
            _userRepository = userRepository;
        }

        public decimal GetMaxExpense(string username)
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand($"SELECT MAX(ExpAmt) FROM ExpenseTbl WHERE ExpUser='{username}'", _sqlConnection);
            decimal maxExpense = Convert.ToDecimal(command.ExecuteScalar());
            _sqlConnection.Close();
            return maxExpense;
        }
        public decimal GetMinExpense(string username)
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand($"SELECT MIN(ExpAmt) FROM ExpenseTbl WHERE ExpUser='{username}'", _sqlConnection);
            decimal minExpense = Convert.ToDecimal(command.ExecuteScalar());
            _sqlConnection.Close();
            return minExpense;
        }

        public decimal GetTotalExpense(string username)
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand($"SELECT SUM(ExpAmt) FROM ExpenseTbl WHERE ExpUser='{username}'", _sqlConnection);
            decimal totalExpense = Convert.ToDecimal(command.ExecuteScalar());
            _sqlConnection.Close();
            return totalExpense;
        }

        public decimal GetTotalExpenseByCategory(string username, string selectedCat)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand($"SELECT SUM(ExpAmt) FROM ExpenseTbl WHERE ExpUser=@username and ExpCat=@selectedCat", _sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@selectedCat", selectedCat);

                object result = command.ExecuteScalar();

                // Check if the result is DBNull
                if (result != DBNull.Value)
                {
                    // If not DBNull, convert it to decimal
                    return Convert.ToDecimal(result);
                }
                else
                {
                    // If DBNull, return 0 or throw an exception, depending on your requirement
                    // Here, I'm returning 0
                    return 0;
                }
            }
            finally
            {
                // Close the connection in the finally block to ensure it's always closed
                _sqlConnection.Close();
            }
        }




        public string GetBestCategory()
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT ExpCat FROM ExpenseTbl WHERE ExpAmt = (SELECT MAX(ExpAmt) FROM ExpenseTbl)", _sqlConnection);
            string bestCategory = command.ExecuteScalar().ToString();
            _sqlConnection.Close();
            return bestCategory;
        }

        public string GetWorstCategory()
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT ExpCat FROM ExpenseTbl WHERE ExpAmt = (SELECT MIN(ExpAmt) FROM ExpenseTbl)", _sqlConnection);
            string worstCategory = command.ExecuteScalar().ToString();
            _sqlConnection.Close();
            return worstCategory;
        }

        public decimal GetAverageExpense(string username)
        {
            _sqlConnection.Open();
            SqlCommand command = new SqlCommand($"SELECT AVG(ExpAmt) FROM ExpenseTbl WHERE ExpUser='{username}'", _sqlConnection);
            decimal averageExpense = Convert.ToDecimal(command.ExecuteScalar());
            _sqlConnection.Close();
            return averageExpense;
        }
        public DataTable GetExpensesByUser(string username)
        {
            User user = _userRepository.GetUserByUsername(username);
            if (user != null)
            {
                _sqlConnection.Open();
                string query = "SELECT * FROM ExpenseTbl WHERE ExpUser=@user";
                SqlCommand command = new SqlCommand(query, _sqlConnection);
                command.Parameters.AddWithValue("@user", Login.User);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                _sqlConnection.Close();
                return dataTable;
            }
            else
            {
                // Handle case where user is not found
                return new DataTable();
            }
        }

        public DataTable GetExpensesByUserAndCategory(string username, string category)
        {
            _sqlConnection.Open();
            string query = "SELECT * FROM ExpenseTbl WHERE ExpUser=@username AND ExpCat=@category";
            SqlCommand command = new SqlCommand(query, _sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@category", category);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            _sqlConnection.Close();
            return dataTable;
        }
        public DataTable GetAllExpenses()
        {
            _sqlConnection.Open();
            string query = "SELECT * FROM ExpenseTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, _sqlConnection);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            _sqlConnection.Close();
            return dataset.Tables[0];
        }

        public DataTable GetExpensesByCategory(string category)
        {
            _sqlConnection.Open();
            string query = $"SELECT * FROM ExpenseTbl WHERE ExpCat = '{category}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, _sqlConnection);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            _sqlConnection.Close();
            return dataset.Tables[0];
        }

        public void AddExpense(string name, decimal amount, string category, DateTime date, string comment, string user)
        {
            _sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ExpenseTbl (ExpName, ExpAmt, ExpCat, ExpDate, ExpComment, ExpUser) VALUES (@EN, @EA, @EC, @ED, @ECo, @EU)", _sqlConnection);
            cmd.Parameters.AddWithValue("@EN", name);
            cmd.Parameters.AddWithValue("@EA", amount);
            cmd.Parameters.AddWithValue("@EC", category);
            cmd.Parameters.AddWithValue("@ED", date);
            cmd.Parameters.AddWithValue("@ECo", comment);
            cmd.Parameters.AddWithValue("@EU", user);
            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

    }
}
