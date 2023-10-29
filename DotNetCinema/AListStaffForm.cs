using DotNetCinema.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetCinema
{
    public partial class AListStaffForm : Form
    {
        public AListStaffForm()
        {
            InitializeComponent();
            PopulateStaff(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Return to home
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void PopulateStaff(DataGridView staffListGridView)
        {
            List<User> staff = Employee.ListUserType(User.GetUsersFromDB(), "Manager");

            foreach (User user in staff)
            {
                string name = user.FirstName + " " + user.LastName;
                staffListGridView.Rows.Add(name, user.Email, user.Phone, user.DOB);
            }
        }

    }
}
