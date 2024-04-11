using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.RepositoryPattern.Interfaces
{
    public interface IAdminAccessRepository
    {
        void AddAdmin(string username, string password);

        bool ValidateAdminCredentials(string username, string password);
    }
}
