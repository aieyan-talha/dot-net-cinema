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
    public partial class SListMoviesForm : Form
    {
        public SListMoviesForm()
        {
            InitializeComponent();
            PopulateMovies(dataGridView1);
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

        private void SListMoviesForm_Load(object sender, EventArgs e)
        {

        }

        private static void PopulateMovies(DataGridView viewMovies)
        {
            List<Movie> movies = Movie.GetMoviesFromDB();

            foreach (Movie movie in movies)
            {
                viewMovies.Rows.Add(movie.Name, movie.Genre, movie.Start_date, movie.End_date);
            }
        }
    }
}
