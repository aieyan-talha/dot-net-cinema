using DotNetCinema.Users;
using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}

