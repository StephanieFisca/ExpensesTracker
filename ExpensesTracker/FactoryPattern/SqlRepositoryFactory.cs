using ExpensesTracker.Factory.Interface;
using ExpensesTracker.Repositories;
using ExpensesTracker.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Factory
{
    public class SqlRepositoryFactory : IRepositoryFactory
    {
        private readonly SqlConnection _sqlConnection;
        private readonly IUserRepository _userRepository;

        public SqlRepositoryFactory(SqlConnection sqlConnection, IUserRepository userRepository)
        {
            _sqlConnection = sqlConnection;
            _userRepository = userRepository;
        }

        public IExpenseRepository CreateExpenseRepository()
        {
            return new SqlExpenseRepository(_sqlConnection, _userRepository);
        }

        public IUserRepository CreateUserRepository()
        {
            return new SqlUserRepository(_sqlConnection);
        }

        public IAdminAccessRepository CreateAdminAccessRepository()
        {
            return new SqlAdminAccessRepository(_sqlConnection);
        }
    }

}
