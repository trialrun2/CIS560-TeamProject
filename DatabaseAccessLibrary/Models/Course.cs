using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary.Models
{
    public class Course
    {
        public int Id { get; }

        public string Name { get; }

        public int StudentCapacity { get; }

        public Course(int id, string name, int capacity)
        {
            Id = id;
            Name = name;
            StudentCapacity = capacity;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
