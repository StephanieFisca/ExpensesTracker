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
    public partial class MainMenu : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IExpenseRepository _expenseRepository;

        public MainMenu(IUserRepository userRepository, IExpenseRepository expenseRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _expenseRepository = expenseRepository;
            DayLbl.Text = DateTime.Today.Day.ToString();
            MonthLbl.Text = DateTime.Today.Month.ToString();
            UNameLbl.Text = Login.User;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses(_expenseRepository);
            expenses.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses(_expenseRepository);
            viewExpenses.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login(_userRepository);
            login.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(_expenseRepository);
            reports.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
