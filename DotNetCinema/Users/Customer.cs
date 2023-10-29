using DotNetCinema.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DotNetCinema.Database;

namespace DotNetCinema.Users
{
    internal class Customer : User
    {
        public int Points {  get; set; }
        public int userId { get; set; } 
        public Customer() : base()
        {
            Points = 0;
            userId = 0;
        }

        public Customer(int id, int points, int userId, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
            this.Points = points;
            this.userId = userId;
        }

        /// <summary>
        /// Method to get customer from DB
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer GetCustomerFromDB(int id)
        {
            int user_id = 0;
            string connectionString = Common.connectionString;
            Customer customer = new Customer();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[Customers] WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user_id = Convert.ToInt32(reader["user_id"]);
                            }
                        }
                    }

                    sqlQuery = "Select * FROM [dbo].[Users] WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", user_id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
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

                                customer = new Customer(user_id, 0, user_id, firstName, lastName, email, phone, password, userName, DOB, gender, userType);

                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return customer;
        }

        /// <summary>
        /// Method to edit own account
        /// </summary>
        public void EditAccount() 
        {
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE [dbo].[Users] SET email = @Email, phone = @Phone, password = @Password, username = @Username WHERE id = @UserId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@Phone", this.Phone);
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@Username", this.UserName);
                        cmd.Parameters.AddWithValue("@UserId", this.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected < 0)
                        {
                            Console.WriteLine("Couldn't edit user with user id: {0}", Id);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        /// <summary>
        /// Method to get all customers from DB
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetCustomersFromDB()
        {
            List<Customer> customers = new List<Customer>();

            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = @"SELECT c.id, c.points, c.user_id, u.first_name, u.last_name, u.email, u.phone, 
                            u.password, u.DOB, u.gender, u.type, u.username 
                            FROM [dbo].[Customers] c 
                            INNER JOIN [dbo].[Users] u ON c.user_id = u.id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["Id"]);
                                int points = Convert.ToInt32(reader["points"]);
                                int userId = Convert.ToInt32(reader["user_id"]);
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

                                Customer customer = new Customer(id, points, userId, firstName, lastName, email, phone, password, userName, DOB, gender, userType);

                                customers.Add(customer);
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }

            return customers;
        }        
    }
}
