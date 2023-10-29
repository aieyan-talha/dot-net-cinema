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
    public partial class SSearchMoviesForm : Form
    {
        public SSearchMoviesForm()
        {
            InitializeComponent();
            this.Controls.Add(dataGridView1);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            string regexMovie = textBox1.Text;
            dataGridView1.Rows.Clear();
            PopulateMovies(regexMovie, dataGridView1);
        }

        /// <summary>
        /// Function to add movie data to table
        /// </summary>
        /// <param name="regexMovie"></param>
        /// <param name="viewMovies"></param>
        private static void PopulateMovies(string regexMovie, DataGridView viewMovies)
        {
            List<Movie> movies = Movie.GetMoviesFromDB();

            foreach (Movie movie in Employee.SearchMovie(regexMovie, movies))
            {
                viewMovies.Rows.Add(movie.Name, movie.Genre, movie.Start_date, movie.End_date);
            }
        }
    }
}
