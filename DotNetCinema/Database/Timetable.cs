using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static DotNetCinema.Users.User;

namespace DotNetCinema.Database
{
    internal class Timetable
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Capacity { get; set; }
        public DateTime Date { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set;}


        private static List<int> timeSlotsPerDay = new List<int> 
        { 
            10,
            12,
            14,
            16,
            18,
            20,
            22,
        };

        public Timetable() 
        {
            Id = 0;
            Movie = new Movie();
            Capacity = 0;
            Date = DateTime.MinValue;
            Start_time = DateTime.MinValue;
            End_time = DateTime.MinValue;
        }

        public Timetable(int id, Movie movie, int capacity, DateTime date, DateTime start_time, DateTime end_time)
        {
            Id = id;
            Movie = movie;
            Capacity = capacity;
            Date = date;
            Start_time = start_time;
            End_time = end_time;
        }

        public static List<Timetable> GenerateTimeTableForDate(List<Movie> moviesOfTheDay, DateTime date)
        {
            List<Timetable> timeSlots = new List<Timetable>();
            Random random = new Random();

            List<Movie> sortedMovies = moviesOfTheDay
                .OrderByDescending(m => m.Priority)
                .ThenByDescending(m => m.Start_date)
                .Take(4)
                .ToList();

            List<int> remainingTimeSlots = new List<int>(timeSlotsPerDay);

            do
            {
                foreach (Movie movie in sortedMovies)
                {
                    //Break the loop if there are no remaining slots
                    if (remainingTimeSlots.Count == 0) break;

                    //Get a random slot to assign to the movie
                    int randomTimeSlot = random.Next(remainingTimeSlots.Count);

                    int selectedTimeSlot = remainingTimeSlots[randomTimeSlot];

                    DateTime startTime = date.AddHours(selectedTimeSlot);
                    DateTime endTime = date.AddHours(selectedTimeSlot + 2);

                    Timetable slotInput = new Timetable(movie.Id, movie, 20, date, startTime, endTime);

                    // Create a TimeTable entry and add it to the list
                    timeSlots.Add(slotInput);

                    remainingTimeSlots.RemoveAt(randomTimeSlot);
                }

            } while (remainingTimeSlots.Count > 0);

            return timeSlots;
        }

        public static List<Timetable> GenerateTimeTableBetweenDates(DateTime startDate, DateTime endDate)
        {
            List<Timetable> timeTable = new List<Timetable>();

            List<Movie> movies = Movie.GetMoviesBetweenDates(startDate, endDate);

            DateTime currentDate = startDate;
            //Loop between each day
            while (currentDate <= endDate)
            {
                List<Movie> moviesForSpecificDate = movies
                    .Where(movie => currentDate >= movie.Start_date && currentDate <= movie.End_date)
                    .ToList();

                List<Timetable> timeTableForTheDay = Timetable.GenerateTimeTableForDate(moviesForSpecificDate, currentDate);

                foreach (Timetable timeslot in timeTableForTheDay)
                {
                    timeTable.Add(timeslot);
                }

                currentDate = currentDate.AddDays(1);
            }

            return timeTable;
        }

        public static bool AddTimeSlotsInDB(List<Timetable> timeslots)
        {
            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    foreach (Timetable timeslot in timeslots)
                    {
                        string query = "INSERT INTO [dbo].[Timetable] ( movie_id, capacity, date, start_time, end_time) " +
                           "VALUES ( @MovieId, @Capacity, @Date, @StartTime, @EndTime)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Assuming 'timetable' object properties correspond to the table columns
                            command.Parameters.AddWithValue("@MovieId", timeslot.Movie.Id); // Assuming Movie has an 'Id' property
                            command.Parameters.AddWithValue("@Capacity", timeslot.Capacity);
                            command.Parameters.AddWithValue("@Date", timeslot.Date);
                            command.Parameters.AddWithValue("@StartTime", timeslot.Start_time);
                            command.Parameters.AddWithValue("@EndTime", timeslot.End_time);

                            //Check how many rows effected
                            command.ExecuteNonQuery();
                        }
                    }

                    return true;
                } catch (SqlException sqlException) 
                { 
                    MessageBox.Show(sqlException.Message, "Sql Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sql Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } finally
                {
                    //Check if the connection is open before closing
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public static List<Timetable> GetAllAvailableTimeSlots()
        {
            List<Timetable> timetable = new List<Timetable>();

            string connectionString = Common.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT [id], [movie_id], [capacity], [date], [start_time], [end_time] " +
                           "FROM [dbo].[Timetable] " +
                           "WHERE [date] >= @Today";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["Id"]);
                                int movieId = Convert.ToInt32(reader["movie_id"]);
                                int capacity = Convert.ToInt32(reader["capacity"]);
                                DateTime date = reader.GetDateTime(reader.GetOrdinal("date"));
                                DateTime startTime = reader.GetDateTime(reader.GetOrdinal("start_time"));
                                DateTime endTime = reader.GetDateTime(reader.GetOrdinal("end_time"));

                                Movie movie = Movie.GetMoviesById(movieId);

                                Timetable timeslot = new Timetable(id, movie, capacity, date, startTime, endTime);

                                timetable.Add(timeslot);
                            }
                        }

                    }

                }
                catch (SqlException sqlException)
                {
                    MessageBox.Show(sqlException.Message, "Sql Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sql Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Check if the connection is open before closing
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }


            return timetable;
        }

        public static List<Timetable> GetMovieTimeSlotsForDate(int movieId, DateTime date)
        {
            List<Timetable> allTimeslots = Timetable.GetAllAvailableTimeSlots();

            List<Timetable> slotsForSpecificMovieAndDate = allTimeslots
                .Where(slot => slot.Movie.Id == movieId && slot.Date.Date == date.Date)
                .ToList();

            return slotsForSpecificMovieAndDate;
        }

        public static Timetable GetTimeSlotById (int id)
        {
            List<Timetable> allTimeslots = Timetable.GetAllAvailableTimeSlots();

            Timetable slot = allTimeslots.Where(ts => ts.Id == id).First();

            return slot;
        }
    }
}
