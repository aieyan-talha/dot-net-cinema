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
    public partial class UserPage : Form
    {
        public UserPage()
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Booking Form
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show Booking Form
            BookingForm bookingForm = new BookingForm();
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
