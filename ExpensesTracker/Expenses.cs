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
    public partial class Expenses : Form
    {
        private readonly IExpenseRepository _expenseRepository;

        public Expenses(IExpenseRepository expenseRepository)
        {
            InitializeComponent();
            _expenseRepository = expenseRepository;
        }

        private void Clear()
        {
            ExpNameLbl.Text = "";
            ExpDescriptionLbl.Text = "";
            ExpAmountLbl.Text = "";
            ExpCategoryLbl.SelectedIndex = 0;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ExpNameLbl.Text == "" || ExpAmountLbl.Text == "" || ExpDescriptionLbl.Text == "" || ExpCategoryLbl.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    decimal amount = decimal.Parse(ExpAmountLbl.Text);
                    DateTime date = ExpDOB.Value.Date;
                    _expenseRepository.AddExpense(ExpNameLbl.Text, amount, ExpCategoryLbl.SelectedItem.ToString(), date, ExpDescriptionLbl.Text, Login.User);
                    MessageBox.Show("Expense Added");
                    Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid amount format. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
