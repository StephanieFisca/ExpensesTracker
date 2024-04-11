using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.RepositoryPattern.Interfaces
{
    public interface IUserRepository
    {
        bool ValidateUserCredentials(string username, string password);

        User GetUserByUsername(string username);
        void AddUser(string userName, DateTime dob, string phone, string password, string address);
        DataTable GetAllUsers();

    }
}
