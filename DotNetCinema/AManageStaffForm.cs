using DotNetCinema.Users;
using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DotNetCinema.Users.User;

namespace DotNetCinema
{
    public partial class AManageStaffForm : Form
    {
        public AManageStaffForm()
        {
            InitializeComponent();
            dobDatePicker.MaxDate = DateTime.Today;

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Save the staff info into the database
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string username = txtUsername.Text;
            DateTime dob = dobDatePicker.Value;
            string gender = genderComboBox.SelectedItem.ToString() ?? "";

            bool hasErrors = false;


            //Check for empty fields
            if (firstName == "")
            {
                first_name_error.Text = "First name is requried";
                hasErrors = true;
            }
            else
            {
                first_name_error.Text = "";
                hasErrors = false;
            }

            if (lastName == "")
            {
                last_name_error.Text = "Last name is requried";
                hasErrors = true;
            }
            else
            {
                last_name_error.Text = "";
                hasErrors = false;
            }

            if (email == "" || email != "" && Common.IsValidEmail(email))
            {
                email_error.Text = "Email address is not valid";
                hasErrors = true;
            }
            else
            {

                email_error.Text = "";
                hasErrors = false;

            }

            if (phone == "")
            {
                mobile_error.Text = "Phone number is requried";
                hasErrors = true;
            }
            else
            {
                mobile_error.Text = "";
                hasErrors = false;
            }

            if (gender == "")
            {
                gender_error.Text = "Gender is requried";
                hasErrors = true;
            }
            else
            {
                gender_error.Text = "";
                hasErrors = false;
            }

            if (username == "")
            {
                userName_error.Text = "User name is requried";
                hasErrors = true;
            }
            else
            {
                userName_error.Text = "";
                hasErrors = false;
            }


            // Directly set UserType to Manager
            UserType type = UserType.Manager;


            //Lets add staff to the DB if no error exist
            if (!hasErrors)
            {
                // Generate a password.
                string password = GetRandomPassword(8);

                // Call the AddUser method
                User newUser = Admin.AddUser(firstName, lastName, email, phone, password, username, dob, gender, UserType.Manager);

                if (newUser.Id > 0)
                {
                    // Show Completion Message Form
                    AAddCompForm addccompform = new AAddCompForm();
                    this.Close();
                    addccompform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to add the user.");
                }
            }
        }

        private string GetRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }
    }
}
