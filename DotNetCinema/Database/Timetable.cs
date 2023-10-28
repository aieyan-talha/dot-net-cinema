using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCinema.Database
{
    internal class Timetable
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Capacity { get; set; }
        public DateTime Date { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set;}

        public Timetable() 
        {
            Id = 0;
            Movie = new Movie();
            Capacity = 0;
            Date = DateTime.MinValue;
            Start_time = DateTime.MinValue;
            End_time = DateTime.MinValue;
        }
        public Timetable(int id, Movie movie, int capacity, DateTime date, DateTime start_time, DateTime end_time)
        {
            Id = id;
            Movie = movie;
            Capacity = capacity;
            Date = date;
            Start_time = start_time;
            End_time = end_time;
        }
    }
}
