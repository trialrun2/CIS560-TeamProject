using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccessLibrary.Models;
using DatabaseAccessLibrary;

namespace SchoolDatabaseApp.Forms
{
    public partial class StudentView : Form
    {
        private Student _student;

        private int StudentID;

        public DatabaseHandler database { get; set; }

        public StudentView()
        {
            InitializeComponent();
        }

        private void uxCourses_SelectedIndexChanged(object sender, EventArgs e) => UpdateStudent(false);

        private void uxEnrollButton_Click(object sender, EventArgs e)
        {
            database.CreateEnrollment(StudentID, ((Course)uxCourseOptions.SelectedItem).Id, DateTimeOffset.UtcNow);
            UpdateStudent(true);
        }

        private void uxSubmitAssignmentButton_Click(object sender, EventArgs e)
        {
            database.CreateSubmittedAssignment();
            UpdateStudent(false);
        }

        private void uxCurrentSemester_SelectedIndexChanged(object sender, EventArgs e) => UpdateStudent(true);

        public void Start(int studentId)
        {
            StudentID = studentId;

            uxCurrentSemester.DataSource = database.GetSemesters();         

            UpdateStudent(true);

            Show();
        }

        private void UpdateStudent(bool updateCourses)
        {
            _student = database.GetStudent(StudentID, uxCurrentSemester.SelectedIndex + 1);
            if (updateCourses) _student.Courses = database.RetrieveStudentCourses(StudentID, uxCurrentSemester.SelectedIndex + 1);

            if (_student.Courses.Count > 0) 
                _student.AssignmentsDue = database.FetchAssignmentsDue(StudentID, _student.Courses[uxCourses.SelectedIndex >= 0 ? uxCourses.SelectedIndex : 0].Id);
            else _student.AssignmentsDue = new List<Assignment>();


            if (_student.Courses.Count > 0) _student.SubmittedAssignments = database.FetchSubmittedAssignments(StudentID, _student.Courses[uxCourses.SelectedIndex >= 0 ? uxCourses.SelectedIndex : 0].Id);
            else _student.SubmittedAssignments = new List<SubmittedAssignment>();

            uxStudentInfoLabel.Text = $"{_student.FirstName} {_student.LastName} | ID: {_student.Id} | # Enrolled Courses: {_student.Courses.Count} | Assignments Due: {_student.AssignmentsDue.Count} | GPA: {_student.GradeAverage}";

            if (updateCourses) uxCourses.DataSource = _student.Courses;
            uxCourseOptions.DataSource = database.GetUnEnrolledCourses(_student.Id, uxCurrentSemester.SelectedIndex + 1);

            if (_student.Courses.Count > 0) uxCourseInfoLabel.Text = _student.Courses[uxCourses.SelectedIndex >= 0 ? uxCourses.SelectedIndex : 0].Name;
            else uxCourseInfoLabel.Text = "None";

            uxAssignmentsDue.DataSource = _student.AssignmentsDue;
            uxSubmittedAssignments.DataSource = _student.SubmittedAssignments;
        }

    }
}
