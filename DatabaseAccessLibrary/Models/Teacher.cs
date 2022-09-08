using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary.Models
{
    public class Teacher : IPerson
    {
        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public List<Assignment> Assignments { get; }

        public List<string> Categories { get; }

        public List<Course> Courses { get; }

        public Teacher(int id, string firstname, string lastname, List<Assignment> assignments, List<string> categories)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Assignments = assignments;
            Categories = categories;
        }
    }
}
