using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary.Models
{
    public class Student : IPerson
    {
        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }
        
        public List<Course> Courses { get; set; }

        public List<SubmittedAssignment> SubmittedAssignments { get; set; }

        public List<Assignment> AssignmentsDue { get; set; }

        public int GradeAverage { get; set; }

        public Student(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }



    }
}
