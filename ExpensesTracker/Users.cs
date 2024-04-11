using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExpensesTracker.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using ExpensesTracker.RepositoryPattern.Interfaces;
using ExpensesTracker.Factory.Interface;
using ExpensesTracker.Factory;

namespace ExpensesTracker
{
    public partial class Users : Form
    {
        private readonly IUserRepository _userRepository;

        public Users(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            ShowUser();
        }

        private void ShowUser()
        {
            try
            {
                DataTable usersTable = _userRepository.GetAllUsers();
                UserDGV.DataSource = usersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void Clear()
        {
            UNameTxt.Text = "";
            UPasswordTxt.Text = "";
            UPhoneTxt.Text = "";
            UAddressTxt.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UNameTxt.Text == "" || UPhoneTxt.Text == "" || UPasswordTxt.Text == "" || UAddressTxt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    string userName = UNameTxt.Text;
                    DateTime dob = UDOB.Value.Date;
                    string phone = UPhoneTxt.Text;
                    string password = UPasswordTxt.Text;
                    string address = UAddressTxt.Text;

                    _userRepository.AddUser(userName, dob, phone, password, address);

                    MessageBox.Show("User Added");
                    ShowUser();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            IRepositoryFactory factory = new SqlRepositoryFactory(SqlConnectionManager.Instance, _userRepository);
            IExpenseRepository expenseRepository = factory.CreateExpenseRepository();
            AdminExpenses adminExpenses = new AdminExpenses(expenseRepository);
            adminExpenses.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            IRepositoryFactory factory = new SqlRepositoryFactory(SqlConnectionManager.Instance, _userRepository);
            //IExpenseRepository expenseRepository = factory.CreateExpenseRepository();

            IAdminAccessRepository adminAccessRepository = factory.CreateAdminAccessRepository();
            AddAdmin addAdmin = new AddAdmin(adminAccessRepository);
            addAdmin.Show();
            this.Hide();
        }
    }
}
