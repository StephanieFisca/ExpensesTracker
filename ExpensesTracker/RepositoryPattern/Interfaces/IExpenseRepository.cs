using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.RepositoryPattern.Interfaces
{
    //Repository pattern for expenses
    public interface IExpenseRepository
    {
        decimal GetMaxExpense(string username);
        decimal GetMinExpense(string username);
        decimal GetTotalExpense(string username);
        decimal GetTotalExpenseByCategory(string username, string selectedCat);
        string GetBestCategory();
        string GetWorstCategory();
        decimal GetAverageExpense(string username);
        DataTable GetExpensesByUser(string username);
        DataTable GetExpensesByUserAndCategory(string username, string category);
        DataTable GetAllExpenses();
        DataTable GetExpensesByCategory(string category);
        void AddExpense(string name, decimal amount, string category, DateTime date, string comment, string user);
    }
}
