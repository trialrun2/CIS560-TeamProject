using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary.Models
{
    public class Assignment
    {
        public int Id { get; }

        public string Name { get; }

        public int Category { get; }

        public DateTimeOffset AssignedDate { get; }

        public DateTimeOffset DueDate { get; }

        public int TotalPoints { get; }

        public bool Removed { get; }

        public Assignment(int id, string name, int category, DateTimeOffset adate, DateTimeOffset ddate, int points, bool removed)
        {
            Id = id;
            Name = name;
            Category = category;
            AssignedDate = adate;
            DueDate = ddate;
            TotalPoints = points;
            Removed = removed;
        }

        public override string ToString() => $"{Name} | {Category} | Due: {DueDate}";
    }
}
