using ExpensesTracker.Repositories;
using ExpensesTracker.RepositoryPattern.Interfaces;
using System;
using System.Data.SqlClient;
using System.Drawing; // Add this namespace for Color
using System.Windows.Forms; // Add this namespace for Form

namespace ExpensesTracker
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startP = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 10;
            MyProgress.Value = startP;
            MyProgress.BackColor = Color.PeachPuff; // Add Color namespace before PeachPuff
            PercentageLbl.Text = startP + "%";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
               
                IUserRepository userRepository = new SqlUserRepository(SqlConnectionManager.Instance);
                Login login = new Login(userRepository);
                this.Hide();
                login.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
