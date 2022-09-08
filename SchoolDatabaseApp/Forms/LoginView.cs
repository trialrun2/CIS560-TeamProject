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

namespace SchoolDatabaseApp.Forms
{
    public partial class LoginView : Form
    {
        public StudentView StudentView { get; set; }

        public TeacherView TeacherView { get; set; }

        private DatabaseHandler _databaseHandler;

        public LoginView(DatabaseHandler databaseHandler)
        {
            InitializeComponent();
            _databaseHandler = databaseHandler;
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordHandler.Authenticate(uxUsername.Text, uxPassword.Text, _databaseHandler, out int personId))
            {
                Hide();
                if (personId <= 90)
                {
                    StudentView.Start(personId);
                    Hide();
                }
                else
                {
                    TeacherView.Start(personId);
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Invlaid Username Or Password");
                ResetGUI();
            }
        }

        private void uxUsername_TextChanged(object sender, EventArgs e) => uxPassword.Enabled = true;

        private void uxPassword_TextChanged(object sender, EventArgs e) => uxLoginButton.Enabled = true;

        private void ResetGUI()
        {
            uxUsername.Text = "";
            uxPassword.Text = "";
            uxPassword.Enabled = false;
            uxLoginButton.Enabled = false;
        }
    }
}
