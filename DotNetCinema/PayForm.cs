using DotNetCinema.Database;
using DotNetCinema.Users;
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
    public partial class PayForm : Form
    {
        private int userId;
        private int movieId;
        private int timeslotId;
        private int nSeats;

        public PayForm(int userId, int movieId, int timeslotId, int nSeats)
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
            Movie movie = Movie.GetMoviesById(movieId);
            Timetable slot = Timetable.GetTimeSlotById(timeslotId);

            List<Customer> customers = Customer.GetCustomersFromDB();

            Customer customer = customers.Where(cust => cust.userId == userId).First();

            // Add tickets to db
            for (int i=0; i<nSeats; i++)
            {
                Ticket newTicket = new Ticket(0, movie, slot, customer, 15, "Standard");
                newTicket.AddTicketToDb();
            }


            // Show Confirmation Form
            ConfirmationForm confirmationForm = new ConfirmationForm(userId, movieId, timeslotId, nSeats);
            confirmationForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Return to home
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void date_label_Click(object sender, EventArgs e)
        {

        }
    }
}
