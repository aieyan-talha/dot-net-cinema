using DotNetCinema.Database;
using DotNetCinema.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetCinema
{
    public partial class BookingForm : Form
    {
        private int movieId;
        private int userId;

        private DateTime selectedDate;
        private int timeslotId;
        private int selectedCapacity;

        public BookingForm(int userId, int movieId)
        {
            this.movieId = movieId;
            this.userId = userId;

            InitializeComponent();

            IntializeDataIntoField(userId, movieId);

            available_times.Enabled = false;
            nPeople.Enabled = false;
        }

        private void IntializeDataIntoField(int userid, int movieId)
        {
            //Get Movie Data
            Movie movie = Movie.GetMoviesById(movieId);
            List<Timetable> timeSlots = Timetable.GetAllAvailableTimeSlots();

            movie_name.Text = movie.Name;

            var queryResult = timeSlots
                .Where(tt => tt.Movie.Id == movie.Id) // Filter by the specific movie ID
                .GroupBy(tt => tt.Date) // Group by Date to eliminate duplicates
                .Select(group => group.First());

            List<string> dates = new List<string>();

            foreach (var timeslot in queryResult)
            {
                dates.Add(timeslot.Date.ToString("yyyy-MM-dd"));
            }

            available_dates.Items.AddRange(dates.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show PayForm
            PayForm payForm = new PayForm(userId, movieId, timeslotId, selectedCapacity);

            this.Hide();
            payForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Return to Home
            Form1 form1 = new Form1();

            form1.Show();

            this.Close();
        }

        private void available_times_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSlot = available_times.SelectedItem.ToString() ?? "";
            if (selectedSlot != "")
            {
                //Set capacity
                List<Timetable> timeslots = Timetable.GetMovieTimeSlotsForDate(movieId, selectedDate);
                DateTime startTime = selectedDate.AddHours(int.Parse(selectedSlot));

                Timetable slot = timeslots.Where(ts => ts.Start_time == startTime).First();

                List<string> availableCapacity = new List<string>();

                for (int i = 0; i < slot.Capacity; i++)
                {
                    int index = i + 1;
                    availableCapacity.Add(index.ToString());
                }


                timeslotId = slot.Id;
                nPeople.Enabled = true;
                nPeople.Items.Clear();
                nPeople.Items.AddRange(availableCapacity.ToArray());
            }
            else
            {
                nPeople.Enabled = false;
                nPeople.Items.Clear();
            }
        }

        private void available_dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add values to available times
            // Get value
            string selectedDate = available_dates.SelectedItem.ToString() ?? "";

            if (selectedDate != "")
            {
                // Get all timeslots for the day
                List<Timetable> timeslots = Timetable.GetMovieTimeSlotsForDate(movieId, DateTime.Parse(selectedDate));

                List<string> hourValues = new List<string>();

                foreach (var slot in timeslots)
                {
                    string hour = slot.Start_time.Hour.ToString("00");
                    hourValues.Add(hour);
                }

                this.selectedDate = DateTime.Parse(selectedDate);

                available_times.Enabled = true;
                available_times.Items.Clear();
                available_times.Items.AddRange(hourValues.ToArray());
            }
            else
            {
                available_times.Enabled = false;
                available_times.Items.Clear();
            }

        }

        private void nPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capacity = nPeople.SelectedItem.ToString() ?? "";

            if (capacity != "")
            {
                selectedCapacity = int.Parse(capacity);
            }
        }
    }
}
