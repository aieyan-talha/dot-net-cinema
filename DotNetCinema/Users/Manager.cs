using DotNetCinema.Database;
using DotNetCinema.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCinema.Users
{
    internal class Manager : Employee
    {
        public Manager() : base()
        {
        }

        public Manager(int id, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
        }

        /// <summary>
        /// Method to add a new movie to database, the newly created movie is returned
        /// </summary>
        /// <param name="movie"></param>
        public static Movie AddMovie(string name, int length, string genre, string img_path, int runtime, int priority, DateTime start_date, DateTime end_date, string description)
        {
            string connectionString = Common.connectionString;
            Movie movie = new Movie();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "INSERT INTO [dbo].[Movies] (name, length, genre, img_path, runtime, priority, start_date, end_date, description) " +
                    "VALUES (@Name, @Length, @Genre, @Img_path, @Runtime, @Priority, @Start_date, @End_date, @Description); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Length", length);
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.Parameters.AddWithValue("@Img_path", img_path);
                        cmd.Parameters.AddWithValue("@Runtime", runtime);
                        cmd.Parameters.AddWithValue("@Priority", priority);
                        cmd.Parameters.AddWithValue("@Start_date", start_date);
                        cmd.Parameters.AddWithValue("@End_date", end_date);
                        cmd.Parameters.AddWithValue("@Description", description);

                        int id = Convert.ToInt32(cmd.ExecuteScalar());

                        if (id < 0)
                        {
                            Console.WriteLine("Adding new Movie didn't work");
                        }

                        movie = new Movie(id, name, length, genre, img_path, runtime, priority, start_date, end_date, description);

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return movie;
        }

        /// <summary>
        /// Method to edit movie in database
        /// </summary>
        /// <param name="movie"></param>
        public static void EditMovie(Movie movie) 
        {
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE [dbo].[Movies] SET name = @Name, length = @Length, genre = @Genre, img_path = @Img_path, runtime = @Runtime, priority = @Priority, description = @Description WHERE Id = @MovieId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", movie.Name);
                        cmd.Parameters.AddWithValue("@Length", movie.Length);
                        cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                        cmd.Parameters.AddWithValue("@Img_path", movie.Img_path);
                        cmd.Parameters.AddWithValue("@Runtime", movie.Runtime);
                        cmd.Parameters.AddWithValue("@Priority", movie.Priority);
                        cmd.Parameters.AddWithValue("@Description", movie.Description);
                        cmd.Parameters.AddWithValue("@MovieId", movie.Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected < 0)
                        {
                            Console.WriteLine("Couldn't edit movie with movie id: {0}", movie.Id);
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
