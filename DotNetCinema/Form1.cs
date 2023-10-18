using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DotNetCinema
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Projects\\UTS\\Dot Net\\dot-net-cinema\\DotNetCinema\\ApplicationDatabase.mdf\";Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConnection = new SqlConnection(@connectionString))
            {;
                SqlConnection.Open();
                string query = "SELECT * FROM Users";

                using (SqlCommand command = new SqlCommand(query, SqlConnection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var data = reader["first_name"].ToString();
                        // Assuming you have a ListBox named listBox1 on your form
                        dummyData.Items.Add(data ?? "");
                    }
                }
            }

            
        }
    }
}