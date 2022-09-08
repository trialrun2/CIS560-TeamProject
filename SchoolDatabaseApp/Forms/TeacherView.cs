using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccessLibrary;
using DatabaseAccessLibrary.Models;
namespace SchoolDatabaseApp.Forms
{
    public partial class TeacherView : Form
    {
        public DatabaseHandler database { get; set; }
        public CreateAssignmentCategoryDialog categoryDialog { get; set; }

        public CreateAssignmentDialog assignmentDialog { get; set; }

        public CreateCourseDialog courseDialog { get; set; }

        public GradeAssignmentDialog gradeDialog { get; set; }

        public Teacher teacher { get; set; }

        public int TeacherID { get; set; }

        public TeacherView()
        {
            InitializeComponent();
        }

        private void uxCreateCourse_Click(object sender, EventArgs e)
        {
            if (courseDialog.ShowDialog() == DialogResult.OK)
            {
                database.CreateCourse(default, default, default, default); // TODO
            }
            UpdateGUI();
        }

        private void uxCurrentSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void uxCreateAssignmentCategoryButton_Click(object sender, EventArgs e)
        {
            if (categoryDialog.ShowDialog() == DialogResult.OK)
            {
                database.CreateAssignmentCategory(default, default); // TODO
            }
            UpdateGUI();
        }

        private void uxGradeAssignmentButton_Click(object sender, EventArgs e)
        {
            if (gradeDialog.ShowDialog() == DialogResult.OK)
            {
                database.GradeAssignment();
            }
            UpdateGUI();
        }

        private void uxAddAssignmentButton_Click(object sender, EventArgs e)
        {
            if (assignmentDialog.ShowDialog() == DialogResult.OK)
            {
                database.CreateAssignment(teacher.Courses[uxCourses.SelectedIndex].Id, default, "", DateTimeOffset.UtcNow, default, 0);
            }
            UpdateGUI();
        }

        private void uxRemoveAssignmentButton_Click(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        public void Start(int personId)
        {
            uxCurrentSemester.DataSource = database.GetSemesters();
            uxCurrentSemester.SelectedIndex = 0;

            TeacherID = personId;

            UpdateGUI();

            Show();
        }

        private void UpdateGUI()
        {
            teacher = database.GetTeacher(TeacherID, uxCurrentSemester.SelectedIndex + 1);
            uxTeacherInfoLabel.Text = $"{teacher.FirstName} {teacher.LastName} | # of Courses: {teacher.Courses.Count}";

            uxCourses.DataSource = teacher.Courses;
            uxCourseNameLabel.Text = teacher.Courses[uxCourses.SelectedIndex].Name;
            uxNumOfStudentsLabel.Text = $"Student Capacity: {teacher.Courses[uxCourses.SelectedIndex].StudentCapacity}";
            uxStartDateLabel.Text = $"Start Date: {database.GetSemesters()[uxCurrentSemester.SelectedIndex].StartDate}";
            uxEndDateLabel.Text = $"End Date: {database.GetSemesters()[uxCurrentSemester.SelectedIndex].EndDate}";

            uxStudents.DataSource = database.RetrieveStudents(uxCourses.SelectedIndex);

            uxReports.DataSource = database.GetReport(uxReportOptions.SelectedIndex);
            uxReports.Refresh();
        }
    }
}
