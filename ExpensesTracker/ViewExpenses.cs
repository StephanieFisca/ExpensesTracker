using ExpensesTracker.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExpensesTracker
{
    public partial class ViewExpenses : Form
    {
        private readonly IExpenseRepository _expenseRepository;

        public ViewExpenses(IExpenseRepository expenseRepository)
        {
            InitializeComponent();
            _expenseRepository = expenseRepository;
            ShowExpenses();
        }

        private void ShowExpenses()
        {
            DataTable expensesTable = _expenseRepository.GetExpensesByUser(Login.User);
            ExpensesDGV.DataSource = expensesTable;
        }

        private void FilterByCategory()
        {
            string selectedCategory = ExpCategoryLbl.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                DataTable filteredExpensesTable = _expenseRepository.GetExpensesByUserAndCategory(Login.User, selectedCategory);
                ExpensesDGV.DataSource = filteredExpensesTable;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowExpenses();
        }

        private void ExpCategoryLbl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }
    }
}
