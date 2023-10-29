using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetCinema.Users;
using DotNetCinema.Database;
using DotNetCinema.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DotNetCinema
{
    public partial class AAddMoviesForm : Form
    {
        public AAddMoviesForm()
        {
            InitializeComponent();
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

        // Sign out button
        private void button3_Click(object sender, EventArgs e)
        {
            // Return to home
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        // Close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add a movie button
        private void button3_Click_1(object sender, EventArgs e)
        {
            // Getting the values from the form controls
            string movieName = movie_name.Text;
            int movieLength;
            string movieGenre = genre.Text;
            string imageLink = image_link.Text;
            int moviePriority = (int)priority.Value;
            DateTime movieStartDate = start_date.Value;
            DateTime movieEndDate = end_date.Value;
            string movieDescription = description.Text;

            bool hasErrors = false;

            //Check for empty fields
            if (movieName == "")
            {
                movie_name_error.Text = "Movie name is required";
                hasErrors = true;
            }
            else
            {
                movie_name_error.Text = "";
            }

            if (!int.TryParse(length.Text, out movieLength) || movieLength <= 0)
            {
                length_error.Text = "Movie length is required and a valid number";
                hasErrors = true;
            }
            else
            {
                length_error.Text = "";
            }

            if (movieGenre == "")
            {
                genre_error.Text = "Genre is required";
                hasErrors = true;
            }
            else
            {
                genre_error.Text = "";
            }

            if (imageLink == "")
            {
                image_link_error.Text = "Image link is required";
                hasErrors = true;
            }
            else
            {
                image_link_error.Text = "";
            }

            if (moviePriority <= 0)
            {
                priority_error.Text = "Movie priority is required and should be over 0";
                hasErrors = true;
            }
            else
            {
                priority_error.Text = "";
            }

            if (movieStartDate > movieEndDate)
            {
                start_date_error.Text = "Start date cannot be after end date.";
                hasErrors = true;
            }
            else
            {
                start_date_error.Text = "";
            }

            if (movieDescription == "")
            {
                description_error.Text = "User name is required";
                hasErrors = true;
            }
            else
            {
                description_error.Text = "";
            }

            if (!hasErrors)
            {
                // Using the values to add a movie to the database
                Movie newMovie = Manager.AddMovie(movieName, movieLength, movieGenre, imageLink, movieLength, moviePriority, movieStartDate, movieEndDate, movieDescription);

                if (newMovie != null && newMovie.Id > 0)
                {
                    // Clearing all form controls to allow for another entry
                    ClearForm();

                    // Show Adding Completion Form and close the current form
                    AAddCompForm addCompForm = new AAddCompForm();
                    this.Close();
                    addCompForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to add the movie. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            // Clearing all form controls to allow for another entry
            movie_name.Text = "";
            length.Text = "";
            genre.Text = "";
            image_link.Text = "";
            priority.Value = 1;
            start_date.Value = DateTime.Today;
            end_date.Value = DateTime.Today;
            description.Text = "";
        }



    }
}
