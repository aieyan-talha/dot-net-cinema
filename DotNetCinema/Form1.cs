using DotNetCinema.Database;
using DotNetCinema.Users;

namespace DotNetCinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string password = login_password.Text;

            List<User> users = User.GetUsersFromDB();

            bool userExists = users.Any(user => user.UserName == username && user.Password == password);

            if (userExists)
            {
                MessageBox.Show("Login Successfull");
                invalid_login_label.Text = string.Empty;
            } else
            {
                invalid_login_label.Text = "Invalid username or password";
            }
        }
    }
}