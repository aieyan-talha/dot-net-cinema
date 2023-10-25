using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetCinema.Users
{
    internal class User
    {
        public enum UserType
        {
            Admin,
            Manager,
            Customer
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; } 
        public UserType Type { get; set; }


        public User() 
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Password = string.Empty;
            UserName = string.Empty;
            DOB = DateTime.MinValue;
            Type = UserType.Admin;
            Gender = string.Empty;
        }

        public User(int id, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
            UserName = userName;
            DOB = dob;
            Gender = gender;
            Type = type;
        }

        public static List<User> GetUsersFromDB()
        {
            List<User> users = new List<User>();

            string connectionString = Common.connectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[Users]";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["Id"]);
                                string firstName = reader.GetString(reader.GetOrdinal("first_name"));
                                string lastName = reader.GetString(reader.GetOrdinal("last_name"));
                                string email = reader.GetString(reader.GetOrdinal("email"));
                                string phone = reader.GetString(reader.GetOrdinal("phone"));
                                string password = reader.GetString(reader.GetOrdinal("password"));
                                string userName = reader.GetString(reader.GetOrdinal("username"));
                                DateTime DOB = reader.GetDateTime(reader.GetOrdinal("DOB"));
                                string gender = reader.GetString(reader.GetOrdinal("gender"));
                                string type = reader.GetString(reader.GetOrdinal("type"));

                                UserType userType = UserType.Customer;

                                try
                                {
                                    // Convert string type to UserType enum. The true part takes care of case-insensitive input
                                    userType = (UserType)Enum.Parse(typeof(UserType), type, true);
                                }
                                catch (ArgumentException)
                                {
                                    Console.WriteLine("Invalid input string");
                                }

                                User user = new User(id, firstName, lastName, email, phone, password, userName, DOB, gender, userType);

                                users.Add(user);
                            }
                        }
                    }

                } catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return users;
        }
    }
}
