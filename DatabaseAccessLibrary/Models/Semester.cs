using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary.Models
{
    public class Semester
    {
        public int Id { get; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public string Name { get; }

        public Semester(int id, DateTimeOffset sd, DateTimeOffset ed, string name)
        {
            Id = id;
            StartDate = sd;
            EndDate = ed;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
