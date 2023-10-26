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
        public Customer() : base()
        {
            Points = 0;
        }

        public Customer(int id, int points, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
            this.Points = points;
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

        /* TODO doesn't work yet
        /// <summary>
        /// Method to return a list of all the tickets user bought
        /// </summary>
        /// <returns></returns>
        public List<Ticket> TicketHistory() 
        {
            List<Ticket> tickets = new List<Ticket>();

            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[Tickets] WHERE customer_id = @Customer_id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmd.Parameters.AddWithValue("@customer_id", Id);
                                int id = Convert.ToInt32(reader["id"]);
                                int movie_id = Convert.ToInt32(reader["movie_id"]);
                                int time_id = Convert.ToInt32(reader["time_id"]);
                                int customer_id = Convert.ToInt32(reader["Customer_id"]);
                                int price = Convert.ToInt32(reader["price"]);
                                string type = reader.GetString(reader.GetOrdinal("type"));

                                Movie movie = (Movie) getById.ById("Movies", movie_id);
                                Timetable timetable = (Timetable) getById.ById("Timetable", time_id);
                                Customer customer = (Customer)getById.ById("Users", customer_id);

                                Ticket ticket = new Ticket(id, movie, timetable, customer, price, type);

                                tickets.Add(ticket);
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return tickets;
        }*/

        //TODO
        public void BookTicket()
        {

        }
    }
}
