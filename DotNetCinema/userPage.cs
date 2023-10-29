using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetCinema.Database;
using DotNetCinema.Users;

namespace DotNetCinema
{
    public partial class UserPage : Form
    {
        public int userId { get; set; }
        public UserPage()
        {
            InitializeComponent();

            List<Movie> moviesOfTheDay = Movie.GetMoviesForTheDay();

            AddMovieDataToPage(moviesOfTheDay);
        }

        private void AddMovieDataToPage(List<Movie> moviesOftheDay)
        {
            int pictureBoxY = 205;
            int movieNameY = 205;
            int movieRuntimeY = 240;
            int movieDescriptionY = 260;
            int bookingButtonY = 305;
            FontFamily calibri = new FontFamily("Calibri");
            FontFamily calibriLight = new FontFamily("Calibri Light");

            foreach (Movie movie in moviesOftheDay)
            {
                PictureBox pictureBox = new PictureBox();
                Label movieName = new Label();
                Label movieRuntime = new Label();
                Label movieDescription = new Label();
                Button bookingButton = new Button();

                //Setup picture box
                pictureBox.Location = new Point(182, pictureBoxY);
                pictureBox.BackColor = Color.Black;
                pictureBox.Anchor = AnchorStyles.None;
                pictureBox.Size = new Size(125, 140);

                //Setup movie name label
                movieName.Location = new Point(350, movieNameY);
                movieName.Text = movie.Name;
                movieName.Height = 30;

                movieName.Font = new Font(calibri, 16, FontStyle.Bold);
                movieName.Anchor = AnchorStyles.None;

                //Setup movie runtime label
                movieRuntime.Location = new Point(350, movieRuntimeY);
                movieRuntime.Text = "120 min";

                movieRuntime.Font = new Font(calibri, 10, FontStyle.Regular);
                movieRuntime.Anchor = AnchorStyles.None;

                //Setup movie description label
                movieDescription.Location = new Point(350, movieDescriptionY);
                movieDescription.Text = movie.Description;

                movieDescription.Font = new Font(calibriLight, 10, FontStyle.Regular);
                movieDescription.Anchor = AnchorStyles.None;

                //Setup booking button
                bookingButton.Location = new Point(350, bookingButtonY);
                bookingButton.Font = new Font(calibri, 10, FontStyle.Regular);
                bookingButton.ForeColor = Color.White;
                bookingButton.BackColor = Color.FromArgb(44, 44, 44);
                bookingButton.Width = 190;
                bookingButton.Height = 40;
                bookingButton.Text = "BOOK";
                bookingButton.Anchor = AnchorStyles.None;
                bookingButton.FlatStyle = FlatStyle.Flat;

                bookingButton.Tag = movie;
                bookingButton.Click += new System.EventHandler(BookingButton_Click);


                this.Controls.Add(pictureBox);
                this.Controls.Add(movieName);
                this.Controls.Add(movieRuntime);
                this.Controls.Add(movieDescription);
                this.Controls.Add(bookingButton);

                pictureBoxY += 170;
                movieNameY += 170;
                movieRuntimeY += 170;
                movieDescriptionY += 170;
                bookingButtonY += 170;
            }
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            if (sender is Button bookingButton)
            {
                if (bookingButton.Tag is Movie movie)
                {
                    //Redirect to booking here
                    BookingForm bookingForm = new BookingForm(userId, movie.Id);

                    this.Hide();
                    bookingForm.Show();
                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Booking Form
            BookingForm bookingForm = new BookingForm(0, 0);
            bookingForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show Booking Form
            BookingForm bookingForm = new BookingForm(0, 0);
            bookingForm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item as a string
            string selectedItem = comboBox1.SelectedItem.ToString();

            Form formToOpen = null;

            // Check the selected item and show the corresponding form
            switch (selectedItem)
            {
                case "My Tickets":
                    formToOpen = new MyTicketsForm();
                    break;

                case "My Watchlist":
                    formToOpen = new MyWatchForm();
                    break;

                case "My Points":
                    formToOpen = new MyPointsForm();
                    break;

                case "Sign Out":
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                    break;
            }

            // If a matching form is found, show it
            if (formToOpen != null)
            {
                formToOpen.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
