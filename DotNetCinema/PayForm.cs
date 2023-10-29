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
        public PayForm(int userId, int movieId, int timeslotId, int nSeats)
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Show Confirmation Form
            ConfirmationForm confirmationForm = new ConfirmationForm();
            confirmationForm.Show();
            this.Close();
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
