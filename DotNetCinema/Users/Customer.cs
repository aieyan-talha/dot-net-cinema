using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DotNetCinema.Users
{
    internal class Customer : User
    {
        public int Points {  get; set; }
        public Customer() : base()
        {
            Points = 0;
        }

        public Customer(int points, int id, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
            this.Points = points;
        }
    }
}
