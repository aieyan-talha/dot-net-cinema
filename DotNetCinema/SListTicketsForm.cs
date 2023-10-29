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
    public partial class SListTicketsForm : Form
    {
        public SListTicketsForm()
        {
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            PopulateMovieBox(comboBox1);
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Function to add data to combobox
        /// </summary>
        /// <param name="movieComboBox"></param>
        private static void PopulateMovieBox(ComboBox movieComboBox)
        {
            List<Movie> movies = Movie.GetActiveMovies();

            foreach (Movie movie in movies)
            {
                movieComboBox.Items.Add(movie.Name);
            }
        }

        /// <summary>
        /// Function to add ticket data to table
        /// </summary>
        /// <param name="viewTickets"></param>
        /// <param name="movie"></param>
        private static void PopulateTicket(DataGridView viewTickets, Movie movie)
        {
            List<Ticket> tickets = Ticket.GetTicketsFromDB();

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Movie.Id == movie.Id)
                {
                    string name = ticket.Customer.FirstName + " " + ticket.Customer.LastName;
                    viewTickets.Rows.Add(name, ticket.Movie.Name, ticket.Timetable.Date);

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            List<Movie> movies = Movie.GetActiveMovies();
            dataGridView1.Rows.Clear();
            foreach (Movie movie in movies)
            {
                if (movie.Name == selectedItem)
                {
                    PopulateTicket(dataGridView1, movie);
                    break;
                }
            }
        }
    }
}
