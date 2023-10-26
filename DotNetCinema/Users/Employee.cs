using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static DotNetCinema.Users.User;

namespace DotNetCinema.Users
{
    internal class Employee : User
    {
        public Employee() : base()
        {
        }

        public Employee(int id, string firstName, string lastName, string email, string phone, string password, string userName, DateTime dob, string gender, UserType type) : base(id, firstName, lastName, email, phone, password, userName, dob, gender, type)
        {
        }

        /// <summary>
        /// Method returns list of specific User types in database
        /// </summary>
        /// <param name="users"></param>
        /// <param name="type"></param>
        /// <returns>List<User></User></returns>
        public static List<User> ListUserType(List<User> users, string typeUser)
        {
            List<User> userTypes = new List<User>();
            foreach (User user in users)
            {
                if (user.Type.ToString() == typeUser)
                {
                    userTypes.Add(user);
                }
            }
            return userTypes;
        }

        /// <summary>
        /// Method returns list of certain type of Users whose names match pattern
        /// </summary>
        /// <param name="employeeRegex"></param>
        /// <param name="users"></param>
        /// <param name="type"></param>
        /// <returns>List<User></User></returns>
        public static List<User> SearchUserType(string userRegex, List<User> users, string typeUser) 
        {
            List<User> userTypes = new List<User>();
            foreach (User user in users)
            {
                if (user.Type.ToString() == typeUser)
                {
                    if (Regex.IsMatch(user.FirstName, userRegex, RegexOptions.IgnoreCase) || Regex.IsMatch(user.LastName, userRegex, RegexOptions.IgnoreCase))
                    {
                        userTypes.Add(user);
                    }
                }
            }
            return userTypes;
        }   
    }
}
