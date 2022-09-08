using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDatabaseApp.Forms
{
    public partial class CreateCourseDialog : Form
    {
        public CreateCourseDialog()
        {
            InitializeComponent();
        }

        private void uxName_TextChanged(object sender, EventArgs e)
        {
            if (uxCapacity.Value > 0) uxAddButton.Enabled = true;
        }

        private void uxCapacity_ValueChanged(object sender, EventArgs e)
        {
            if (uxName.Text != "") uxAddButton.Enabled = true;
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void uxAddButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
