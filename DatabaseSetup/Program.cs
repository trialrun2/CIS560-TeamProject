using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccessLibrary;

namespace DatabaseSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHandler database = new DatabaseHandler(@"Server = (localdb)\MSSQLLocalDb; Database = SchoolDatabase; Integrated Security = SSPI; ");

            Random random = new Random(123456789);

            string[] courseNames = { "CIS", "STAT", "MATH", "ENGL", "HIST" };

            Console.WriteLine("Creating courses... ");
            for (int i = 1; i < 11; i++)
            {
                database.CreateCourse(i, 1, $"{courseNames[random.Next(0, 5)]} {random.Next(100, 500)}", random.Next(20, 50));
                database.CreateCourse(i, 1, $"{courseNames[random.Next(0, 5)]} {random.Next(100, 500)}", random.Next(20, 50));
                database.CreateCourse(i, 1, $"{courseNames[random.Next(0, 5)]} {random.Next(100, 500)}", random.Next(20, 50));
            }

            Console.WriteLine("Creating Assignment categories... ");
            for (int i = 1; i < 31; i++)
            {
                database.CreateAssignmentCategory(i, "Exams");
                database.CreateAssignmentCategory(i, "Quizes");
                database.CreateAssignmentCategory(i, "Homework");
            }

            Console.WriteLine("Creating Assignments... ");
            for (int i = 1; i < 31; i++)
            {
                database.CreateAssignment(i, i * 1, "Exam 1", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 50);
                database.CreateAssignment(i, i * 1, "Exam 2", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 50);
                database.CreateAssignment(i, i * 2, "Quiz 1", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 15);
                database.CreateAssignment(i, i * 2, "Quiz 2", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 15);
                database.CreateAssignment(i, i * 3, "Homework 1", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 10);
                database.CreateAssignment(i, i * 3, "Homework 2", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 10);
                database.CreateAssignment(i, i * 3, "Homework 3", DateTimeOffset.UtcNow.AddDays(random.NextDouble() * -50), DateTimeOffset.UtcNow.AddDays(random.NextDouble() * 16), 10);
            }

            Console.WriteLine("Enrolling in classes... ");
            for (int i = 1; i < 91; i++)
            {
                List<int> used = new List<int>();

                int x;

                do { x = random.Next(1, 30); } while (used.Contains(x));
                database.CreateEnrollment(i, x, DateTimeOffset.UtcNow);
                used.Add(x);

                do { x = random.Next(1, 30); } while (used.Contains(x));
                database.CreateEnrollment(i, x, DateTimeOffset.UtcNow);
                used.Add(x);

                do { x = random.Next(1, 30); } while (used.Contains(x));
                database.CreateEnrollment(i, x, DateTimeOffset.UtcNow);
            }

            Console.WriteLine("Finished");

        }
    }
}
