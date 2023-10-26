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

namespace DotNetCinema
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            //Get values from fields
            string firstName = register_firstname.Text;
            string lastName = register_lastname.Text;
            string email = register_email.Text;
            string phone = register_mobile.Text;
            string password = register_password.Text;
            string DOB = register_dob.Text;
            string gender = register_gender.Text;
            string type = User.UserType.Customer.ToString();
            string username = register_username.Text;

            string DOBString = Common.convertDateString(DOB);

            bool hasErrors = false;

            //Check for empty fields
            if (email == "") 
            {
                email_address_error.Text = "Email address is requried";
                hasErrors = true;
            } else
            {
                email_address_error.Text = "";
                hasErrors = false;
            }

            if (email != "" && Common.IsValidEmail(email))
            {
                email_address_error.Text = "Email address is not valid";
                hasErrors = true;
            }
            else
            {

                email_address_error.Text = "";
                hasErrors = false;
                
            }

            if (password == "")
            {
                password_error.Text = "Password is requried";
                hasErrors = true;
            }
            else
            {
                password_error.Text = "";
                hasErrors = false;
            }

            if (DOB == "")
            {
                dob_error.Text = "Date of birth is requried";
                hasErrors = true;
            }
            else
            {
                dob_error.Text = "";
                hasErrors = false;
            }

            if (username == "")
            {
                username_error.Text = "Username is requried";
                hasErrors = true;
            }
            else
            {
                username_error.Text = "";
                hasErrors = false;
            }

            
            //Lets add user to the DB if no error exist
            if (!hasErrors)
            {
                User newUser = new User(1, firstName, lastName, email, phone, password, username, DateTime.Parse(DOBString), gender, User.UserType.Customer);

                bool isSuccessful = newUser.AddUserToDB();

                if (isSuccessful)
                {
                    Form1 loginPage = new Form1();

                    this.Hide();
                    loginPage.Show();
                } else
                {
                    MessageBox.Show("Unable to add user to Database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
