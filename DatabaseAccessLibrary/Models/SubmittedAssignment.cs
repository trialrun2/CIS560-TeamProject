using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary.Models
{
    public class SubmittedAssignment
    {
        public int Id { get; }

        public string Name { get; }

        public int Points { get; set; }
         
        public DateTimeOffset TurnedIn { get; set; }

        public bool Removed { get; set; }

        public SubmittedAssignment(int id, string name, int points, DateTimeOffset turnedIn, bool removed)
        {
            Id = id;
            Name = name;
            Points = points;
            TurnedIn = turnedIn;
            Removed = removed;
        }

        public override string ToString()
        {
            return $"{Name} | {Points} | Turned In: {TurnedIn.DateTime}";
        }
    }
}
