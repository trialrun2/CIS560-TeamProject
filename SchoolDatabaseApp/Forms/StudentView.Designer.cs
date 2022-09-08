
namespace SchoolDatabaseApp.Forms
{
    partial class StudentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxTOP1 = new System.Windows.Forms.TableLayoutPanel();
            this.uxCoursesGB = new System.Windows.Forms.GroupBox();
            this.uxCoursesTL = new System.Windows.Forms.TableLayoutPanel();
            this.uxCourses = new System.Windows.Forms.ListBox();
            this.uxCoursesLabel = new System.Windows.Forms.Label();
            this.uxSplitC1 = new System.Windows.Forms.SplitContainer();
            this.uxCourseOptions = new System.Windows.Forms.ComboBox();
            this.uxEnrollButton = new System.Windows.Forms.Button();
            this.uxStudentInfoGP = new System.Windows.Forms.GroupBox();
            this.uxCurrentSemesterLabel = new System.Windows.Forms.Label();
            this.uxStudentInfoLabel = new System.Windows.Forms.Label();
            this.uxCurrentSemester = new System.Windows.Forms.ComboBox();
            this.uxAssignmentGB = new System.Windows.Forms.GroupBox();
            this.uxAssignmentTL = new System.Windows.Forms.TableLayoutPanel();
            this.uxSplitAD = new System.Windows.Forms.SplitContainer();
            this.uxScore = new System.Windows.Forms.NumericUpDown();
            this.uxSubmitAssignmentButton = new System.Windows.Forms.Button();
            this.uxSubmittedAssignmentsLabel = new System.Windows.Forms.Label();
            this.uxAssignmentsDueLabel = new System.Windows.Forms.Label();
            this.uxAssignmentsDue = new System.Windows.Forms.ListBox();
            this.uxSubmittedAssignments = new System.Windows.Forms.ListBox();
            this.uxCourseInfoLabel = new System.Windows.Forms.Label();
            this.uxTOP1.SuspendLayout();
            this.uxCoursesGB.SuspendLayout();
            this.uxCoursesTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSplitC1)).BeginInit();
            this.uxSplitC1.Panel1.SuspendLayout();
            this.uxSplitC1.Panel2.SuspendLayout();
            this.uxSplitC1.SuspendLayout();
            this.uxStudentInfoGP.SuspendLayout();
            this.uxAssignmentGB.SuspendLayout();
            this.uxAssignmentTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSplitAD)).BeginInit();
            this.uxSplitAD.Panel1.SuspendLayout();
            this.uxSplitAD.Panel2.SuspendLayout();
            this.uxSplitAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxScore)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTOP1
            // 
            this.uxTOP1.ColumnCount = 2;
            this.uxTOP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25F));
            this.uxTOP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.75F));
            this.uxTOP1.Controls.Add(this.uxCoursesGB, 0, 1);
            this.uxTOP1.Controls.Add(this.uxStudentInfoGP, 0, 0);
            this.uxTOP1.Controls.Add(this.uxAssignmentGB, 1, 1);
            this.uxTOP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTOP1.Location = new System.Drawing.Point(0, 0);
            this.uxTOP1.Name = "uxTOP1";
            this.uxTOP1.RowCount = 2;
            this.uxTOP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11111F));
            this.uxTOP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.88889F));
            this.uxTOP1.Size = new System.Drawing.Size(800, 450);
            this.uxTOP1.TabIndex = 0;
            // 
            // uxCoursesGB
            // 
            this.uxCoursesGB.Controls.Add(this.uxCoursesTL);
            this.uxCoursesGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCoursesGB.Location = new System.Drawing.Point(3, 70);
            this.uxCoursesGB.Name = "uxCoursesGB";
            this.uxCoursesGB.Size = new System.Drawing.Size(228, 377);
            this.uxCoursesGB.TabIndex = 0;
            this.uxCoursesGB.TabStop = false;
            // 
            // uxCoursesTL
            // 
            this.uxCoursesTL.ColumnCount = 1;
            this.uxCoursesTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uxCoursesTL.Controls.Add(this.uxCourses, 0, 1);
            this.uxCoursesTL.Controls.Add(this.uxCoursesLabel, 0, 0);
            this.uxCoursesTL.Controls.Add(this.uxSplitC1, 0, 2);
            this.uxCoursesTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCoursesTL.Location = new System.Drawing.Point(3, 18);
            this.uxCoursesTL.Name = "uxCoursesTL";
            this.uxCoursesTL.RowCount = 3;
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.38095F));
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uxCoursesTL.Size = new System.Drawing.Size(222, 356);
            this.uxCoursesTL.TabIndex = 2;
            // 
            // uxCourses
            // 
            this.uxCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCourses.FormattingEnabled = true;
            this.uxCourses.ItemHeight = 25;
            this.uxCourses.Location = new System.Drawing.Point(3, 27);
            this.uxCourses.Name = "uxCourses";
            this.uxCourses.Size = new System.Drawing.Size(216, 285);
            this.uxCourses.TabIndex = 1;
            this.uxCourses.SelectedIndexChanged += new System.EventHandler(this.uxCourses_SelectedIndexChanged);
            // 
            // uxCoursesLabel
            // 
            this.uxCoursesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.uxCoursesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCoursesLabel.Location = new System.Drawing.Point(3, 0);
            this.uxCoursesLabel.Name = "uxCoursesLabel";
            this.uxCoursesLabel.Size = new System.Drawing.Size(216, 24);
            this.uxCoursesLabel.TabIndex = 2;
            this.uxCoursesLabel.Text = "Courses";
            this.uxCoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxSplitC1
            // 
            this.uxSplitC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSplitC1.Location = new System.Drawing.Point(3, 318);
            this.uxSplitC1.Name = "uxSplitC1";
            // 
            // uxSplitC1.Panel1
            // 
            this.uxSplitC1.Panel1.Controls.Add(this.uxCourseOptions);
            // 
            // uxSplitC1.Panel2
            // 
            this.uxSplitC1.Panel2.Controls.Add(this.uxEnrollButton);
            this.uxSplitC1.Size = new System.Drawing.Size(216, 35);
            this.uxSplitC1.SplitterDistance = 130;
            this.uxSplitC1.TabIndex = 3;
            // 
            // uxCourseOptions
            // 
            this.uxCourseOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCourseOptions.FormattingEnabled = true;
            this.uxCourseOptions.Location = new System.Drawing.Point(0, 0);
            this.uxCourseOptions.Name = "uxCourseOptions";
            this.uxCourseOptions.Size = new System.Drawing.Size(130, 24);
            this.uxCourseOptions.TabIndex = 0;
            // 
            // uxEnrollButton
            // 
            this.uxEnrollButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxEnrollButton.Location = new System.Drawing.Point(0, 0);
            this.uxEnrollButton.Name = "uxEnrollButton";
            this.uxEnrollButton.Size = new System.Drawing.Size(82, 35);
            this.uxEnrollButton.TabIndex = 0;
            this.uxEnrollButton.Text = "Enroll";
            this.uxEnrollButton.UseVisualStyleBackColor = true;
            this.uxEnrollButton.Click += new System.EventHandler(this.uxEnrollButton_Click);
            // 
            // uxStudentInfoGP
            // 
            this.uxTOP1.SetColumnSpan(this.uxStudentInfoGP, 2);
            this.uxStudentInfoGP.Controls.Add(this.uxCurrentSemesterLabel);
            this.uxStudentInfoGP.Controls.Add(this.uxStudentInfoLabel);
            this.uxStudentInfoGP.Controls.Add(this.uxCurrentSemester);
            this.uxStudentInfoGP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxStudentInfoGP.Location = new System.Drawing.Point(3, 3);
            this.uxStudentInfoGP.Name = "uxStudentInfoGP";
            this.uxStudentInfoGP.Size = new System.Drawing.Size(794, 61);
            this.uxStudentInfoGP.TabIndex = 0;
            this.uxStudentInfoGP.TabStop = false;
            this.uxStudentInfoGP.Text = "StudentInfo";
            // 
            // uxCurrentSemesterLabel
            // 
            this.uxCurrentSemesterLabel.AutoSize = true;
            this.uxCurrentSemesterLabel.Location = new System.Drawing.Point(546, 24);
            this.uxCurrentSemesterLabel.Name = "uxCurrentSemesterLabel";
            this.uxCurrentSemesterLabel.Size = new System.Drawing.Size(119, 17);
            this.uxCurrentSemesterLabel.TabIndex = 3;
            this.uxCurrentSemesterLabel.Text = "CurrentSemester:";
            // 
            // uxStudentInfoLabel
            // 
            this.uxStudentInfoLabel.AutoSize = true;
            this.uxStudentInfoLabel.Location = new System.Drawing.Point(9, 24);
            this.uxStudentInfoLabel.Name = "uxStudentInfoLabel";
            this.uxStudentInfoLabel.Size = new System.Drawing.Size(478, 17);
            this.uxStudentInfoLabel.TabIndex = 0;
            this.uxStudentInfoLabel.Text = "Student Name | ID: [] | # Enrolled Courses: [] | Assignments Due: [] | GPA: []";
            // 
            // uxCurrentSemester
            // 
            this.uxCurrentSemester.FormattingEnabled = true;
            this.uxCurrentSemester.Location = new System.Drawing.Point(667, 21);
            this.uxCurrentSemester.Name = "uxCurrentSemester";
            this.uxCurrentSemester.Size = new System.Drawing.Size(121, 24);
            this.uxCurrentSemester.TabIndex = 1;
            this.uxCurrentSemester.SelectedIndexChanged += new System.EventHandler(this.uxCurrentSemester_SelectedIndexChanged);
            // 
            // uxAssignmentGB
            // 
            this.uxAssignmentGB.Controls.Add(this.uxAssignmentTL);
            this.uxAssignmentGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentGB.Location = new System.Drawing.Point(237, 70);
            this.uxAssignmentGB.Name = "uxAssignmentGB";
            this.uxAssignmentGB.Size = new System.Drawing.Size(560, 377);
            this.uxAssignmentGB.TabIndex = 1;
            this.uxAssignmentGB.TabStop = false;
            // 
            // uxAssignmentTL
            // 
            this.uxAssignmentTL.ColumnCount = 2;
            this.uxAssignmentTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uxAssignmentTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uxAssignmentTL.Controls.Add(this.uxSplitAD, 0, 3);
            this.uxAssignmentTL.Controls.Add(this.uxSubmittedAssignmentsLabel, 1, 1);
            this.uxAssignmentTL.Controls.Add(this.uxAssignmentsDueLabel, 0, 1);
            this.uxAssignmentTL.Controls.Add(this.uxAssignmentsDue, 0, 2);
            this.uxAssignmentTL.Controls.Add(this.uxSubmittedAssignments, 1, 2);
            this.uxAssignmentTL.Controls.Add(this.uxCourseInfoLabel, 0, 0);
            this.uxAssignmentTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentTL.Location = new System.Drawing.Point(3, 18);
            this.uxAssignmentTL.Name = "uxAssignmentTL";
            this.uxAssignmentTL.RowCount = 4;
            this.uxAssignmentTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.355938F));
            this.uxAssignmentTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.352704F));
            this.uxAssignmentTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.29136F));
            this.uxAssignmentTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.uxAssignmentTL.Size = new System.Drawing.Size(554, 356);
            this.uxAssignmentTL.TabIndex = 3;
            // 
            // uxSplitAD
            // 
            this.uxSplitAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSplitAD.Location = new System.Drawing.Point(3, 322);
            this.uxSplitAD.Name = "uxSplitAD";
            // 
            // uxSplitAD.Panel1
            // 
            this.uxSplitAD.Panel1.Controls.Add(this.uxScore);
            // 
            // uxSplitAD.Panel2
            // 
            this.uxSplitAD.Panel2.Controls.Add(this.uxSubmitAssignmentButton);
            this.uxSplitAD.Size = new System.Drawing.Size(271, 31);
            this.uxSplitAD.SplitterDistance = 126;
            this.uxSplitAD.TabIndex = 8;
            // 
            // uxScore
            // 
            this.uxScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxScore.Location = new System.Drawing.Point(0, 0);
            this.uxScore.Name = "uxScore";
            this.uxScore.Size = new System.Drawing.Size(126, 22);
            this.uxScore.TabIndex = 0;
            // 
            // uxSubmitAssignmentButton
            // 
            this.uxSubmitAssignmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSubmitAssignmentButton.Location = new System.Drawing.Point(0, 0);
            this.uxSubmitAssignmentButton.Name = "uxSubmitAssignmentButton";
            this.uxSubmitAssignmentButton.Size = new System.Drawing.Size(141, 31);
            this.uxSubmitAssignmentButton.TabIndex = 1;
            this.uxSubmitAssignmentButton.Text = "Submit Assignment";
            this.uxSubmitAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // uxSubmittedAssignmentsLabel
            // 
            this.uxSubmittedAssignmentsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.uxSubmittedAssignmentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSubmittedAssignmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmittedAssignmentsLabel.Location = new System.Drawing.Point(280, 23);
            this.uxSubmittedAssignmentsLabel.Name = "uxSubmittedAssignmentsLabel";
            this.uxSubmittedAssignmentsLabel.Size = new System.Drawing.Size(271, 23);
            this.uxSubmittedAssignmentsLabel.TabIndex = 6;
            this.uxSubmittedAssignmentsLabel.Text = "Submitted Assignments";
            this.uxSubmittedAssignmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxAssignmentsDueLabel
            // 
            this.uxAssignmentsDueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.uxAssignmentsDueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentsDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAssignmentsDueLabel.Location = new System.Drawing.Point(3, 23);
            this.uxAssignmentsDueLabel.Name = "uxAssignmentsDueLabel";
            this.uxAssignmentsDueLabel.Size = new System.Drawing.Size(271, 23);
            this.uxAssignmentsDueLabel.TabIndex = 5;
            this.uxAssignmentsDueLabel.Text = "Assignments Due";
            this.uxAssignmentsDueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxAssignmentsDue
            // 
            this.uxAssignmentsDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentsDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAssignmentsDue.FormattingEnabled = true;
            this.uxAssignmentsDue.ItemHeight = 25;
            this.uxAssignmentsDue.Location = new System.Drawing.Point(3, 49);
            this.uxAssignmentsDue.Name = "uxAssignmentsDue";
            this.uxAssignmentsDue.Size = new System.Drawing.Size(271, 267);
            this.uxAssignmentsDue.TabIndex = 0;
            // 
            // uxSubmittedAssignments
            // 
            this.uxSubmittedAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSubmittedAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmittedAssignments.FormattingEnabled = true;
            this.uxSubmittedAssignments.ItemHeight = 25;
            this.uxSubmittedAssignments.Location = new System.Drawing.Point(280, 49);
            this.uxSubmittedAssignments.Name = "uxSubmittedAssignments";
            this.uxAssignmentTL.SetRowSpan(this.uxSubmittedAssignments, 2);
            this.uxSubmittedAssignments.Size = new System.Drawing.Size(271, 304);
            this.uxSubmittedAssignments.TabIndex = 1;
            // 
            // uxCourseInfoLabel
            // 
            this.uxAssignmentTL.SetColumnSpan(this.uxCourseInfoLabel, 2);
            this.uxCourseInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCourseInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCourseInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.uxCourseInfoLabel.Name = "uxCourseInfoLabel";
            this.uxCourseInfoLabel.Size = new System.Drawing.Size(548, 23);
            this.uxCourseInfoLabel.TabIndex = 9;
            this.uxCourseInfoLabel.Text = "[CourseName] | Overall Grade: []";
            this.uxCourseInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTOP1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.uxTOP1.ResumeLayout(false);
            this.uxCoursesGB.ResumeLayout(false);
            this.uxCoursesTL.ResumeLayout(false);
            this.uxSplitC1.Panel1.ResumeLayout(false);
            this.uxSplitC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSplitC1)).EndInit();
            this.uxSplitC1.ResumeLayout(false);
            this.uxStudentInfoGP.ResumeLayout(false);
            this.uxStudentInfoGP.PerformLayout();
            this.uxAssignmentGB.ResumeLayout(false);
            this.uxAssignmentTL.ResumeLayout(false);
            this.uxSplitAD.Panel1.ResumeLayout(false);
            this.uxSplitAD.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSplitAD)).EndInit();
            this.uxSplitAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uxTOP1;
        private System.Windows.Forms.GroupBox uxStudentInfoGP;
        private System.Windows.Forms.Label uxStudentInfoLabel;
        private System.Windows.Forms.Label uxCurrentSemesterLabel;
        private System.Windows.Forms.ComboBox uxCurrentSemester;
        private System.Windows.Forms.GroupBox uxCoursesGB;
        private System.Windows.Forms.TableLayoutPanel uxCoursesTL;
        private System.Windows.Forms.ListBox uxCourses;
        private System.Windows.Forms.Label uxCoursesLabel;
        private System.Windows.Forms.SplitContainer uxSplitC1;
        private System.Windows.Forms.ComboBox uxCourseOptions;
        private System.Windows.Forms.Button uxEnrollButton;
        private System.Windows.Forms.GroupBox uxAssignmentGB;
        private System.Windows.Forms.TableLayoutPanel uxAssignmentTL;
        private System.Windows.Forms.ListBox uxAssignmentsDue;
        private System.Windows.Forms.ListBox uxSubmittedAssignments;
        private System.Windows.Forms.Label uxSubmittedAssignmentsLabel;
        private System.Windows.Forms.Label uxAssignmentsDueLabel;
        private System.Windows.Forms.SplitContainer uxSplitAD;
        private System.Windows.Forms.NumericUpDown uxScore;
        private System.Windows.Forms.Button uxSubmitAssignmentButton;
        private System.Windows.Forms.Label uxCourseInfoLabel;
    }
}