using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNetCinema.Users.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DotNetCinema.Database;
using DotNetCinema.Users;

namespace DotNetCinema.Utils
{
    public static class Common
    {
        public static string connectionString = "Server=tcp:uts-dot-net.database.windows.net,1433;Initial Catalog=Dot Net Cinema;Persist Security Info=False;User ID=dot-net-admin;Password=SomeRandPass@32998;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }

    public static class getById
    {
        /*
        //TODO; doesn't work yet
        /// <summary>
        /// Method to get Movie, Timetable or User by id
        /// </summary>
        /// <param name="database"></param>
        /// <param name="id_int"></param>
        /// <returns>object</returns>
        public static object ById(string database, int id_int)
        {
            string connectionString = Common.connectionString;
            Object obj = new object();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * FROM [dbo].[@Database] WHERE id = @Id_int";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmd.Parameters.AddWithValue("@Database", database);
                                cmd.Parameters.AddWithValue("@Id_int", id_int);

                                if (database.Equals("Movies"))
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

                                    obj = new Movie(id, name, length, genre, img_path, runtime, priority, start_date, end_date, description);
                                }

                                else if (database.Equals("Timetable")) 
                                {
                                    int id = Convert.ToInt32(reader["id"]);
                                    int movie_id = Convert.ToInt32(reader["movie_id"]);
                                    int capacity = Convert.ToInt32(reader["capacity"]);
                                    DateTime date = reader.GetDateTime(reader.GetOrdinal("date"));
                                    DateTime start_time = reader.GetDateTime(reader.GetOrdinal("start_time"));
                                    DateTime end_time = reader.GetDateTime(reader.GetOrdinal("end_time"));

                                    Movie movie = (Movie)ById("Movies", movie_id);
                                    obj = new Timetable(id, movie, capacity, date, start_time, end_time);
                                } 

                                else if (database.Equals("Users"))
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

                                    obj = new Customer(id, 0, firstName, lastName, email, phone, password, userName, DOB, gender, userType);

                                }
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: {0}", e.Message);
                }
            }
            return obj;
        }*/
    }
}
