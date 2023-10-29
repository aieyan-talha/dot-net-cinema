using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNetCinema.Users.User;

namespace DotNetCinema.Database
{
    internal class Movie
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public string Img_path { get; set; }
        public int Runtime { get; set; }
        public int Priority { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Description { get; set; }

        public Movie()
        {
            Id = 0;
            Name = string.Empty;
            Length = 0;
            Genre = string.Empty;
            Img_path = string.Empty;
            Runtime = 0;
            Priority = 0;
            Start_date = DateTime.MinValue;
            End_date = DateTime.MinValue;
            Description = string.Empty;
        }

        public Movie(int id, string name, int length, string genre, string img_path, int runtime, int priority, DateTime start_date, DateTime end_date, string description) 
        {
            Id = id;
            Name = name;
            Length = length;
            Genre = genre;
            Img_path = img_path;
            Runtime = runtime;
            Priority = priority;
            Start_date = start_date;
            End_date = end_date;
            Description = description;
        }

        /// <summary>
        /// Function to get a list of all the movies in database
        /// </summary>
        /// <returns></returns>
        public static List<Movie> GetMoviesFromDB()
        {
            List<Movie> movies = new List<Movie>();

            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[Movies]";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader.GetString(reader.GetOrdinal("name"));
                                int length = Convert.ToInt32(reader["length"]);
                                string genre = reader.GetString(reader.GetOrdinal("genre"));
                                string img_path = reader.GetString(reader.GetOrdinal("img_path"));
                                int runtime = Convert.ToInt32(reader["runtime"]);
                                int priority = Convert.ToInt32(reader["priority"]);
                                DateTime start_date = reader.GetDateTime(reader.GetOrdinal("start_date"));
                                DateTime end_date = reader.GetDateTime(reader.GetOrdinal("end_date"));
                                string description = reader.GetString(reader.GetOrdinal("description"));

                                Movie movie = new Movie(id, name, length, genre, img_path, runtime, priority, start_date, end_date, description);

                                movies.Add(movie);
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return movies;
        }

        public static Movie GetMovieFromDB(int id)
        {
            string connectionString = Common.connectionString;
            Movie movie = new Movie();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[Movies] WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(reader.GetOrdinal("name"));
                                int length = Convert.ToInt32(reader["length"]);
                                string genre = reader.GetString(reader.GetOrdinal("genre"));
                                string img_path = reader.GetString(reader.GetOrdinal("img_path"));
                                int runtime = Convert.ToInt32(reader["runtime"]);
                                int priority = Convert.ToInt32(reader["priority"]);
                                DateTime start_date = reader.GetDateTime(reader.GetOrdinal("start_date"));
                                DateTime end_date = reader.GetDateTime(reader.GetOrdinal("end_date"));
                                string description = reader.GetString(reader.GetOrdinal("description"));

                                movie = new Movie(id, name, length, genre, img_path, runtime, priority, start_date, end_date, description);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
                return movie;
            }
        }

        public static List<Movie> GetActiveMovies()
        {
            List<Movie> movies = new List<Movie>();

            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM movies " +
                        "WHERE start_date <= CAST(GETDATE() AS DATE) " +
                        "AND end_date >= CAST(GETDATE() AS DATE);";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader.GetString(reader.GetOrdinal("name"));
                                int length = Convert.ToInt32(reader["length"]);
                                string genre = reader.GetString(reader.GetOrdinal("genre"));
                                string img_path = reader.GetString(reader.GetOrdinal("img_path"));
                                int runtime = Convert.ToInt32(reader["runtime"]);
                                int priority = Convert.ToInt32(reader["priority"]);
                                DateTime start_date = reader.GetDateTime(reader.GetOrdinal("start_date"));
                                DateTime end_date = reader.GetDateTime(reader.GetOrdinal("end_date"));
                                string description = reader.GetString(reader.GetOrdinal("description"));

                                Movie movie = new Movie(id, name, length, genre, img_path, runtime, priority, start_date, end_date, description);

                                movies.Add(movie);
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }


            return movies;
        }

        public static List<Movie> GetMoviesBetweenDates(DateTime Start_date, DateTime End_date)
        {
            List<Movie> movies = GetMoviesFromDB();

            List<Movie> activeMovies = movies.Where(movie => movie.Start_date <= End_date && movie.End_date >= Start_date).ToList();

            return activeMovies;
        }
    }
}
