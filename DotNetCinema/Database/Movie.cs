using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCinema.Database
{
    internal class Movie
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public string Img_path { get; set; }
        public int Runtime { get; set; }
        public int Priority { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Description { get; set; }

        public Movie()
        {
            Id = 0;
            Name = string.Empty;
            Length = 0;
            Genre = string.Empty;
            Img_path = string.Empty;
            Runtime = 0;
            Priority = 0;
            Start_date = DateTime.MinValue;
            End_date = DateTime.MinValue;
            Description = string.Empty;
        }

        public Movie(int id, string name, string genre, string img_path, int runtime, int priority, DateTime start_date, DateTime end_date, string description) 
        {
            Id = id;
            Name = name;
            Genre = genre;
            Img_path = img_path;
            Runtime = runtime;
            Priority = priority;
            Start_date = start_date;
            End_date = end_date;
            Description = description;
        }
    }
}
