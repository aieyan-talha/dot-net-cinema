using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCinema.Users
{
    internal class Manager : User
    {
        public Manager() : base()
        {
        }

        public Manager(int id, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
        }
    }
}
