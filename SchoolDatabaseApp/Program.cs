using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccessLibrary;

namespace SchoolDatabaseApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHandler database = new DatabaseHandler(@"Server = (localdb)\MSSQLLocalDb; Database = SchoolDatabase; Integrated Security = SSPI; ");

            Forms.LoginView loginView = new Forms.LoginView(database);

            Forms.CreateAssignmentCategoryDialog categoryDialog = new Forms.CreateAssignmentCategoryDialog();
            Forms.CreateAssignmentDialog assignmentDialog = new Forms.CreateAssignmentDialog();
            Forms.CreateCourseDialog courseDialog = new Forms.CreateCourseDialog();
            Forms.GradeAssignmentDialog gradeDialog = new Forms.GradeAssignmentDialog();

            Forms.StudentView studentView = new Forms.StudentView();
            studentView.database = database;
            
            Forms.TeacherView teacherView = new Forms.TeacherView();
            teacherView.database = database;
            teacherView.categoryDialog = categoryDialog;
            teacherView.assignmentDialog = assignmentDialog;
            teacherView.courseDialog = courseDialog;
            teacherView.gradeDialog = gradeDialog;

            loginView.StudentView = studentView;
            loginView.TeacherView = teacherView;

            Application.Run(loginView);
        }
    }
}
