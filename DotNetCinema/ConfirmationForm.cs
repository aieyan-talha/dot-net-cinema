using DotNetCinema.Database;
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
    public partial class ConfirmationForm : Form
    {
        private int userId;
        private int movieId;
        private int timeslotId;
        private int nSeats;
        public ConfirmationForm(int userId, int movieId, int timeslotId, int nSeats)
        {
            this.userId = userId;
            this.movieId = movieId;
            this.timeslotId = timeslotId;
            this.nSeats = nSeats;

            InitializeComponent();
            InitailiseFormValues();
        }
        public void InitailiseFormValues()
        {
            //Get movie data 
            Movie movie = Movie.GetMoviesById(movieId);
            Timetable slot = Timetable.GetTimeSlotById(timeslotId);
            int ticketPrice = nSeats * 15;

            name_label.Text = movie.Name;
            date_label.Text = slot.Date.ToString("dd-MM-yyyy");
            nTicket_label.Text = nSeats.ToString();
            time_label.Text = slot.Start_time.Hour.ToString("00") + ":00 - " + slot.End_time.Hour.ToString() + ":00";

            price_label.Text = "AUD " + ticketPrice.ToString();
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
            // Return to home
            UserPage userPage = new UserPage();

            this.Hide();
            userPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
