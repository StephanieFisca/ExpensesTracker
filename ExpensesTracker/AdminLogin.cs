using ExpensesTracker.Factory.Interface;
using ExpensesTracker.Factory;
using ExpensesTracker.Repositories;
using ExpensesTracker.RepositoryPattern.Interfaces;
using System.Data.SqlClient;

namespace ExpensesTracker
{
    public partial class AdminLogin : Form
    {
        private readonly IAdminAccessRepository _adminAccessRepository;
        private readonly IUserRepository _userRepository;

        public AdminLogin(IAdminAccessRepository userRepository)
        {
            InitializeComponent();
            _adminAccessRepository = userRepository;
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

            if (_adminAccessRepository.ValidateAdminCredentials(username, password))
            {
                IRepositoryFactory factory = new SqlRepositoryFactory(SqlConnectionManager.Instance, _userRepository);
                IUserRepository userRepository = factory.CreateUserRepository();
                // Valid credentials; proceed to the next form
                Users users = new Users(userRepository);
                users.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new SqlUserRepository(SqlConnectionManager.Instance);
            Login login = new Login(userRepository);
            login.Show();
            this.Hide();
        }
    }
}
