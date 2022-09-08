using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using DatabaseAccessLibrary.Models;

namespace DatabaseAccessLibrary
{
    public class DatabaseHandler
    {
        private readonly string _connectionString;

        public DatabaseHandler(string connection)
        {
            _connectionString = connection;
        }


        #region Create Stuff
        public void CreateAssignmentCategory(int courseId, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The parameter can't be empty.", nameof(name));

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("School.CreateAssignmentCategories", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("CourseId", courseId);
                        command.Parameters.AddWithValue("Name", name);

                        SqlParameter sqlCourseId = command.Parameters.Add("AssignmentCategoriesId", SqlDbType.Int);
                        sqlCourseId.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();
                    }
                }
            }
        }

        public void CreateAssignment(int courseId, int assignmentCategoryId, string name, DateTimeOffset assignedDate, DateTimeOffset dueDate, int totalPoints)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The parameter can't be empty.", nameof(name));

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("School.CreateAssignment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("AssignmentCategoryId", assignmentCategoryId);
                        command.Parameters.AddWithValue("CourseId", courseId);
                        command.Parameters.AddWithValue("Name", name);
                        command.Parameters.AddWithValue("AssignedDate", assignedDate);
                        command.Parameters.AddWithValue("DueDate", dueDate);
                        command.Parameters.AddWithValue("TotalPoints", totalPoints);
                        command.Parameters.AddWithValue("Removed", false);

                        SqlParameter sqlCourseId = command.Parameters.Add("AssignmentId", SqlDbType.Int);
                        sqlCourseId.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();
                    }
                }
            }
        }

        /// <summary>
        /// Creates a new Course in the Database.
        /// </summary>
        /// <param name="teacherId">The Teacher's Id.</param>
        /// <param name="semesterId">The Semester Id.</param>
        /// <param name="name">The Name of the Course.</param>
        /// <param name="studentCapacity">The Student Capacity of the Course.</param>
        /// <returns></returns>
        public int CreateCourse(int teacherId, int semesterId, string name, int studentCapacity)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("The parameter can't be empty.", nameof(name));

            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("School.CreateCourse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("TeacherId", teacherId);
                        command.Parameters.AddWithValue("SemesterId", semesterId);
                        command.Parameters.AddWithValue("Name", name);
                        command.Parameters.AddWithValue("StudentCapacity", studentCapacity);

                        SqlParameter sqlCourseId = command.Parameters.Add("CourseId", SqlDbType.Int);
                        sqlCourseId.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        int courseId = (int)command.Parameters["CourseId"].Value;
                        return courseId;
                    }
                }
            }
        }

        /// <summary>
        /// Creates a new Enrollment in the Database.
        /// </summary>
        /// <param name="studentId">The Student's Id.</param>
        /// <param name="courseId">The Course Id.</param>
        /// <param name="enrollmentDate">The Enrollment date.</param>
        /// <param name="droppedDate">The Dropped date.</param>
        public void CreateEnrollment(int studentId, int courseId, DateTimeOffset enrollmentDate)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("School.CreateEnrollment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("StudentId", studentId);
                        command.Parameters.AddWithValue("CourseId", courseId);
                        command.Parameters.AddWithValue("EnrollmentDate", enrollmentDate);
                        command.Parameters.AddWithValue("DroppedDate", DBNull.Value);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();
                    }
                }
            }
        }

        public void CreateSubmittedAssignment()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Student Stuff
        public Student GetStudent(int studentid, int semesterId)
        {
            string[] names = StudentFetchStudentName(studentid).Split(' ');
            
            Student student = new Student(studentid, names[0], names[1]);

            student.Courses = RetrieveStudentCourses(studentid, semesterId);

            return student;
        }

        public List<Course> RetrieveStudentCourses(int studentId, int semesterId)
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.RetrieveStudentCourses", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("StudentId", studentId);
                    command.Parameters.AddWithValue("SemesterId", semesterId);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var nameOrdinal = reader.GetOrdinal("Name");
                        var idOrdinal = reader.GetOrdinal("CourseId");

                        while (reader.Read())
                        {
                            courses.Add(new Course(reader.GetInt32(idOrdinal), reader.GetString(nameOrdinal), default));
                        }
                    }

                }
            }

            return courses;
        }

        public List<Course> GetUnEnrolledCourses(int id, int semesterId)
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.RetrieveUnenrolledInCourses", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("StudentId", id);
                    command.Parameters.AddWithValue("SemesterId", semesterId);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var nameOrdinal = reader.GetOrdinal("Name");
                        var idOrdinal = reader.GetOrdinal("CourseId");

                        while (reader.Read())
                        {
                            courses.Add(new Course(reader.GetInt32(idOrdinal), reader.GetString(nameOrdinal), default));
                        }
                    }
                }
            }
            return courses;
        }

        public List<Assignment> FetchAssignmentsDue(int studentid, int courseid)
        {
            List<Assignment> assignments = new List<Assignment>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.FetchAssignmentsDue", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("StudentId", studentid);
                    command.Parameters.AddWithValue("CourseId", courseid);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var nameOrdinal = reader.GetOrdinal("Name");
                        var idOrdinal = reader.GetOrdinal("AssignmentId");
                        var catIdOrdinal = reader.GetOrdinal("AssignmentCategoryId");
                        var adateOrdianl = reader.GetOrdinal("AssignedDate");
                        var ddateOrdinal = reader.GetOrdinal("DueDate");
                        var pointsOrdinal = reader.GetOrdinal("TotalPoints");

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(idOrdinal);
                            string name = reader.GetString(nameOrdinal);
                            int cat = reader.GetInt32(catIdOrdinal);
                            DateTimeOffset adate = reader.GetDateTimeOffset(adateOrdianl);
                            DateTimeOffset ddate = reader.GetDateTimeOffset(ddateOrdinal);
                            int points = reader.GetInt32(pointsOrdinal);
                            assignments.Add(new Assignment(id, name, cat, adate, ddate, points, false));
                        }
                    }
                }
            }
            return assignments;
        }

        public List<SubmittedAssignment> FetchSubmittedAssignments(int studentid, int courseid)
        {
            List<SubmittedAssignment> assignments = new List<SubmittedAssignment>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.FetchSubmittedAssignments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("StudentId", studentid);
                    command.Parameters.AddWithValue("CourseId", courseid);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var nameOrdinal = reader.GetOrdinal("Name");
                        var pointsOrdinal = reader.GetOrdinal("EarnedPoints");
                        var idOrdinal = reader.GetOrdinal("AssignmentId");
                        var tdateOrdianl = reader.GetOrdinal("TurnedInDate");

                        while (reader.Read())
                        {
                            assignments.Add(new SubmittedAssignment(reader.GetInt32(idOrdinal), reader.GetString(nameOrdinal), reader.GetInt32(pointsOrdinal), reader.GetDateTimeOffset(tdateOrdianl), false));
                        }
                    }
                }
            }
            return assignments;
        }

        public string StudentFetchStudentName(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.FetchStudentName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("StudentId", id);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var nameOrdinal = reader.GetOrdinal("Name");
                        while(reader.Read()) return reader.GetString(nameOrdinal);
                    }
                }
            }
            return "";
        }
        #endregion


        #region Teacher Stuff
        public Teacher GetTeacher(int id, int symesterId)
        {
            string[] names = FetchTeacherName(id).Split(' ');
            Teacher teacher = new Teacher(id, names[0], names[1], default, default);

            return teacher;
        }

        public string FetchTeacherName(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.FetchTeacherName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("TeacherId", id);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");
                        return $"{reader.GetString(firstNameOrdinal)} {reader.GetString(lastNameOrdinal)}";
                    }
                }
            }
        }

        public object GetReport(int id)
        {
            return default;
        }

        public void GradeAssignment()
        {
            
        }

        public List<string> RetrieveStudents(int courseId)
        {
            List<string> students = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.RetrieveStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("CourseId", courseId);

                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var nameOrdinal = reader.GetOrdinal("Name");

                        while (reader.Read())
                        {
                            students.Add(reader.GetString(nameOrdinal));
                        }
                    }
                }
            }
            return students;
        }
        #endregion


        #region Other Stuff
        public List<Semester> GetSemesters()
        {
            List<Semester> semesters = new List<Semester>();

            for (int i = 1; i < 3; i++)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("School.GetCurrentSemester", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("SemesterId", i);

                        connection.Open();

                        command.ExecuteNonQuery();

                        using (var reader = command.ExecuteReader())
                        {
                            var nameOrdinal = reader.GetOrdinal("Name");
                            
                            while (reader.Read())
                            {
                                semesters.Add(new Semester(i, default, default, reader.GetString(nameOrdinal)));
                            }
                        }

                        connection.Close();
                    }

                    using (SqlCommand command2 = new SqlCommand("School.FetchSemesterStartDate", connection))
                    {
                        command2.CommandType = CommandType.StoredProcedure;

                        command2.Parameters.AddWithValue("SemesterId", i);

                        connection.Open();

                        command2.ExecuteNonQuery();

                        using (var reader = command2.ExecuteReader())
                        {
                            var startDateOrdinal = reader.GetOrdinal("StartDate");
                         
                            while (reader.Read())
                            {
                                semesters[i - 1].StartDate = reader.GetDateTimeOffset(startDateOrdinal);
                            }
                        }

                        connection.Close();
                    }

                    using (SqlCommand command3 = new SqlCommand("School.FetchSemesterEndDate", connection))
                    {
                        command3.CommandType = CommandType.StoredProcedure;

                        command3.Parameters.AddWithValue("SemesterId", i);

                        connection.Open();

                        command3.ExecuteNonQuery();

                        using (var reader = command3.ExecuteReader())
                        {
                            var endDateOrdinal = reader.GetOrdinal("EndDate");

                            while (reader.Read())
                            {
                                semesters[i - 1].EndDate = reader.GetDateTimeOffset(endDateOrdinal);
                            }
                        }
                        connection.Close();
                    }
                }
            }
            return semesters;
        }

        public string GetPasswordHash(string username, out int id)
        {
            string[] vs = username.Split(' ');
            id = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("School.FetchIDFromName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("FirstName", vs[0]);
                    command.Parameters.AddWithValue("LastName", vs[1]);


                    connection.Open();

                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        var idOrdinal = reader.GetOrdinal("PersonId");
                        while (reader.Read())
                        {
                            id = reader.GetInt32(idOrdinal);
                        }
                    }
                }
            }

            return "password";
        }
        #endregion
    }
}
