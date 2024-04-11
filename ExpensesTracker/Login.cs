using ExpensesTracker.Factory.Interface;
using ExpensesTracker.Factory;
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
    public partial class Login : Form
    {
        private readonly IUserRepository _userRepository;
        public static string User;

        public Login(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UNameTxt.Text;
            string password = UPasswordTxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            bool isValidUser = _userRepository.ValidateUserCredentials(username, password);

            if (isValidUser)
            {
                // Example usage
                IRepositoryFactory factory = new SqlRepositoryFactory(SqlConnectionManager.Instance, _userRepository);
                IExpenseRepository expenseRepository = factory.CreateExpenseRepository();
                MainMenu mainMenu = new MainMenu(_userRepository, expenseRepository);
                Login.User = username;
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            IRepositoryFactory factory = new SqlRepositoryFactory(SqlConnectionManager.Instance, _userRepository);
            IAdminAccessRepository adminAccessRepository = factory.CreateAdminAccessRepository();
            AdminLogin mainMenu = new AdminLogin(adminAccessRepository);
            mainMenu.Show();
            this.Hide();
        }
    }
}
