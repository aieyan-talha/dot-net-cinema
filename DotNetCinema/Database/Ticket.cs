using DotNetCinema.Properties;
using DotNetCinema.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using DotNetCinema.Utils;

namespace DotNetCinema.Database
{
    internal class Ticket
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Timetable Timetable { get; set; }
        public Customer Customer { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }

        public Ticket() 
        {
            Id = 0;
            Movie = new Movie();
            Customer = new Customer();
            Timetable = new Timetable();
            Price = 0;
            Type = string.Empty;
        }
        public Ticket(int id, Movie movie, Timetable timetable, Customer customer, int price, string type)
        {
            Id = id;
            Movie = movie;
            Timetable = timetable;
            Customer = customer;
            Price = price;
            Type = type;
        }

        
    }
}
