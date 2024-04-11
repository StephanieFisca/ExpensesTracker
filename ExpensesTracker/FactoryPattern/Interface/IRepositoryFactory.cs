using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesTracker.RepositoryPattern.Interfaces;

namespace ExpensesTracker.Factory.Interface
{
    public interface IRepositoryFactory
    {
        IExpenseRepository CreateExpenseRepository();
        IAdminAccessRepository CreateAdminAccessRepository();
        IUserRepository CreateUserRepository();
    }

}
