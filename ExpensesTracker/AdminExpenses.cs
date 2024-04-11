using ExpensesTracker.Repositories;
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

namespace ExpensesTracker
{
    public partial class AdminExpenses : Form
    {
        private readonly IExpenseRepository _expenseRepository;

        public AdminExpenses(IExpenseRepository expenseRepository)
        {
            InitializeComponent();
            _expenseRepository = expenseRepository;
            ShowExpenses();
        }

        private void ShowExpenses()
        {
            DataTable expenses = _expenseRepository.GetAllExpenses();
            ExpensesDGV.DataSource = expenses;
        }

        private void FilterByCat()
        {
            string selectedCategory = ExpCategoryLbl.SelectedItem?.ToString();
            if (selectedCategory != null)
            {
                DataTable expenses = _expenseRepository.GetExpensesByCategory(selectedCategory);
                ExpensesDGV.DataSource = expenses;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IAdminAccessRepository adminAccessRepository = new SqlAdminAccessRepository(SqlConnectionManager.Instance);
            AdminLogin adminLogin = new AdminLogin(adminAccessRepository);
            adminLogin.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowExpenses();
        }

        private void ExpCategoryLbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCat();
        }
    }
}
