using DotNetCinema.Users;
using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Method to get all the tickets from DB
        /// </summary>
        /// <returns></returns>
        public static List<Ticket> GetTicketsFromDB()
        {
            List<Ticket> tickets = new List<Ticket>();

            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[Tickets]";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                int movie_id = Convert.ToInt32(reader["movie_id"]);
                                int time_id = Convert.ToInt32(reader["time_id"]);
                                int customer_id = Convert.ToInt32(reader["Customer_id"]);
                                int price = Convert.ToInt32(reader["price"]);
                                string type = reader.GetString(reader.GetOrdinal("type"));

                                Movie movie = Movie.GetMovieFromDB(movie_id);
                                Timetable timetable = Timetable.GetTimetableFromDB(time_id);
                                Customer customer = Customer.GetCustomerFromDB(customer_id);


                                Ticket ticket = new(id, movie, timetable, customer, price, type);

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
        }

        /// <summary>
        /// Method to add a ticket to DB
        /// </summary>
        /// <returns></returns>
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
                        command.Parameters.AddWithValue("@movieId", Movie.Id);
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

