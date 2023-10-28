using DotNetCinema.Database;
using DotNetCinema.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetCinema.Users
{
    internal class Admin : Employee
    {
        public Admin() : base()
        {
        }

        public Admin(int id, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
        }

        /// <summary>
        /// Method to add user to database, returns just created user
        /// </summary>
        /// <param name="user"></param>
        public static User AddUser(string firstName, string lastName, string email, string phone, string password, string username, DateTime dob, string gender, UserType type)
        {
            User user = new();
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "INSERT INTO [dbo].[Users] (first_name, last_name, email, phone, password, username, DOB, gender, type) " +
                    "VALUES (@FirstName, @LastName, @Email, @Phone, @Password, @Username, @DOB, @Gender, @Type); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Type", type.ToString());

                        int id = Convert.ToInt32(cmd.ExecuteScalar());

                        if (id < 0)
                        {
                            Console.WriteLine("Adding new User didn't work");
                        }
                        user = new User(id, firstName, lastName, email, phone, password, username, dob, gender, type);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return user;
        }

        /// <summary>
        /// Method to delete user from database
        /// </summary>
        /// <param name="user"></param>
        public static void RemoveUser(User user)
        {
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "DELETE FROM [dbo].[Users] WHERE Id = @UserId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", user.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected < 0)
                        {
                            Console.WriteLine("Couldn't find user with user id: {0}", user.Id);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}" + e.Message);
                }
            }

        }

        /// <summary>
        /// Method to edit existing User in database
        /// </summary>
        /// <param name="user"></param>
        public static void EditUser(User user)
        {
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE [dbo].[Users] SET first_name = @FirstName, last_name = @LastName, email = @Email, phone = @Phone, password = @Password, username = @Username, DOB = @DOB, gender = @Gender, type = @Type WHERE Id = @UserId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", user.LastName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Username", user.UserName);
                        cmd.Parameters.AddWithValue("@DOB", user.DOB);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.Parameters.AddWithValue("@Type", user.Type);
                        cmd.Parameters.AddWithValue("@UserId", user.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected < 0)
                        {
                            Console.WriteLine("Couldn't edit user with user id: {0}", user.Id);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

        }
    }
}
