using ExpensesTracker.Repositories;
using ExpensesTracker.RepositoryPattern.Interfaces;
using System.Data.SqlClient;

namespace ExpensesTracker
{
    public partial class AddAdmin : Form
    {
        private readonly IAdminAccessRepository _adminAccessRepository;

        public AddAdmin(IAdminAccessRepository adminAccessRepository)
        {
            InitializeComponent();
            _adminAccessRepository = adminAccessRepository;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string username = UNameTxt.Text;
            string password = UPasswordTxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            // Add the new admin to the database
            _adminAccessRepository.AddAdmin(username, password);
            MessageBox.Show("Admin added successfully.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new SqlUserRepository(SqlConnectionManager.Instance);
            Users users = new Users(userRepository);
            users.Show();
            this.Hide();
        }
    }
}
