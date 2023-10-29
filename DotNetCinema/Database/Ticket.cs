using DotNetCinema.Properties;
using DotNetCinema.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using DotNetCinema.Utils;

namespace DotNetCinema.Database
{
    internal class Ticket
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Timetable Timetable { get; set; }
        public Customer Customer { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }

        public Ticket() 
        {
            Id = 0;
            Movie = new Movie();
            Customer = new Customer();
            Timetable = new Timetable();
            Price = 0;
            Type = string.Empty;
        }
        public Ticket(int id, Movie movie, Timetable timetable, Customer customer, int price, string type)
        {
            Id = id;
            Movie = movie;
            Timetable = timetable;
            Customer = customer;
            Price = price;
            Type = type;
        }

        public bool AddTicketToDb()
        {
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO [dbo].[Tickets] (movie_id, time_id, customer_id, price, type) VALUES (@movieId, @timeId, @customerId, @price, @type)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@movieId",Movie.Id);
                        command.Parameters.AddWithValue("@timeId", Timetable.Id);
                        command.Parameters.AddWithValue("@customerId", Customer.Id);
                        command.Parameters.AddWithValue("@price", Price);
                        command.Parameters.AddWithValue("@type", Type);

                        // Execute the query
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL-specific exceptions
                    Console.WriteLine("SQL Exception: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    // Handle other non-SQL exceptions
                    Console.WriteLine("Exception: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close(); // Always close the connection when done
                }
            }
        }
    }
}
