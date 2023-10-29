using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNetCinema.Users.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DotNetCinema.Database;
using DotNetCinema.Users;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DotNetCinema.Utils
{
    public static class Common
    {
        public static string connectionString = "Server=tcp:uts-dot-net.database.windows.net,1433;Initial Catalog=Dot Net Cinema;Persist Security Info=False;User ID=dot-net-admin;Password=SomeRandPass@32998;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //This method converts date string recieved from dataTimePicker and converts it to DB date format
        public static string convertDateString(string dateString)
        {
            DateTime inputDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            string output = inputDate.ToString("yyyy-MM-dd");

            return output;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
