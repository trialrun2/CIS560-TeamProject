
namespace SchoolDatabaseApp.Forms
{
    partial class TeacherView
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
            this.uxTL1 = new System.Windows.Forms.TableLayoutPanel();
            this.uxTeacherInfoGB = new System.Windows.Forms.GroupBox();
            this.uxCurrentSemesterLabel = new System.Windows.Forms.Label();
            this.uxTeacherInfoLabel = new System.Windows.Forms.Label();
            this.uxCurrentSemester = new System.Windows.Forms.ComboBox();
            this.uxCoursesGB = new System.Windows.Forms.GroupBox();
            this.uxCoursesTL = new System.Windows.Forms.TableLayoutPanel();
            this.uxCourses = new System.Windows.Forms.ListBox();
            this.uxCoursesLabel = new System.Windows.Forms.Label();
            this.uxCreateCourse = new System.Windows.Forms.Button();
            this.uxTabGroupBox = new System.Windows.Forms.GroupBox();
            this.uxContentTabs = new System.Windows.Forms.TabControl();
            this.uxCourseInfoTab = new System.Windows.Forms.TabPage();
            this.uxEndDateLabel = new System.Windows.Forms.Label();
            this.uxStartDateLabel = new System.Windows.Forms.Label();
            this.uxNumOfStudentsLabel = new System.Windows.Forms.Label();
            this.uxCourseNameLabel = new System.Windows.Forms.Label();
            this.uxAssignmentsTab = new System.Windows.Forms.TabPage();
            this.uxAssignmentsSC = new System.Windows.Forms.SplitContainer();
            this.uxAssignmentCategoriesTL = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxCreateAssignmentCategoryButton = new System.Windows.Forms.Button();
            this.uxAssignmentCategories = new System.Windows.Forms.ListBox();
            this.uxAssignmentsTabs2 = new System.Windows.Forms.TabControl();
            this.uxSubmittedAssignmentsTab = new System.Windows.Forms.TabPage();
            this.uxAssignmentsSC3 = new System.Windows.Forms.SplitContainer();
            this.uxAssignmentOptions = new System.Windows.Forms.ComboBox();
            this.uxAssignmentsSC2 = new System.Windows.Forms.SplitContainer();
            this.uxAssignments = new System.Windows.Forms.ListBox();
            this.uxGradeAssignmentButton = new System.Windows.Forms.Button();
            this.uxAddRemoveTab = new System.Windows.Forms.TabPage();
            this.uxAssignmentTL = new System.Windows.Forms.TableLayoutPanel();
            this.uxARAssignments = new System.Windows.Forms.ListBox();
            this.uxRemoveAssignmentButton = new System.Windows.Forms.Button();
            this.uxAddAssignmentButton = new System.Windows.Forms.Button();
            this.uxStudentsTab = new System.Windows.Forms.TabPage();
            this.uxStudents = new System.Windows.Forms.ListBox();
            this.uxReportsTab = new System.Windows.Forms.TabPage();
            this.uxReportsSC = new System.Windows.Forms.SplitContainer();
            this.uxReportOptions = new System.Windows.Forms.ComboBox();
            this.uxReports = new System.Windows.Forms.DataGridView();
            this.uxTL1.SuspendLayout();
            this.uxTeacherInfoGB.SuspendLayout();
            this.uxCoursesGB.SuspendLayout();
            this.uxCoursesTL.SuspendLayout();
            this.uxTabGroupBox.SuspendLayout();
            this.uxContentTabs.SuspendLayout();
            this.uxCourseInfoTab.SuspendLayout();
            this.uxAssignmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAssignmentsSC)).BeginInit();
            this.uxAssignmentsSC.Panel1.SuspendLayout();
            this.uxAssignmentsSC.Panel2.SuspendLayout();
            this.uxAssignmentsSC.SuspendLayout();
            this.uxAssignmentCategoriesTL.SuspendLayout();
            this.uxAssignmentsTabs2.SuspendLayout();
            this.uxSubmittedAssignmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAssignmentsSC3)).BeginInit();
            this.uxAssignmentsSC3.Panel1.SuspendLayout();
            this.uxAssignmentsSC3.Panel2.SuspendLayout();
            this.uxAssignmentsSC3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxAssignmentsSC2)).BeginInit();
            this.uxAssignmentsSC2.Panel1.SuspendLayout();
            this.uxAssignmentsSC2.Panel2.SuspendLayout();
            this.uxAssignmentsSC2.SuspendLayout();
            this.uxAddRemoveTab.SuspendLayout();
            this.uxAssignmentTL.SuspendLayout();
            this.uxStudentsTab.SuspendLayout();
            this.uxReportsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxReportsSC)).BeginInit();
            this.uxReportsSC.Panel1.SuspendLayout();
            this.uxReportsSC.Panel2.SuspendLayout();
            this.uxReportsSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxReports)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTL1
            // 
            this.uxTL1.ColumnCount = 2;
            this.uxTL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.uxTL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.uxTL1.Controls.Add(this.uxTeacherInfoGB, 0, 0);
            this.uxTL1.Controls.Add(this.uxCoursesGB, 0, 1);
            this.uxTL1.Controls.Add(this.uxTabGroupBox, 1, 1);
            this.uxTL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTL1.Location = new System.Drawing.Point(0, 0);
            this.uxTL1.Name = "uxTL1";
            this.uxTL1.RowCount = 2;
            this.uxTL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.77778F));
            this.uxTL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.22222F));
            this.uxTL1.Size = new System.Drawing.Size(800, 450);
            this.uxTL1.TabIndex = 0;
            // 
            // uxTeacherInfoGB
            // 
            this.uxTL1.SetColumnSpan(this.uxTeacherInfoGB, 2);
            this.uxTeacherInfoGB.Controls.Add(this.uxCurrentSemesterLabel);
            this.uxTeacherInfoGB.Controls.Add(this.uxTeacherInfoLabel);
            this.uxTeacherInfoGB.Controls.Add(this.uxCurrentSemester);
            this.uxTeacherInfoGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTeacherInfoGB.Location = new System.Drawing.Point(3, 3);
            this.uxTeacherInfoGB.Name = "uxTeacherInfoGB";
            this.uxTeacherInfoGB.Size = new System.Drawing.Size(794, 65);
            this.uxTeacherInfoGB.TabIndex = 1;
            this.uxTeacherInfoGB.TabStop = false;
            this.uxTeacherInfoGB.Text = "Teacher Info";
            // 
            // uxCurrentSemesterLabel
            // 
            this.uxCurrentSemesterLabel.AutoSize = true;
            this.uxCurrentSemesterLabel.Location = new System.Drawing.Point(543, 24);
            this.uxCurrentSemesterLabel.Name = "uxCurrentSemesterLabel";
            this.uxCurrentSemesterLabel.Size = new System.Drawing.Size(119, 17);
            this.uxCurrentSemesterLabel.TabIndex = 6;
            this.uxCurrentSemesterLabel.Text = "CurrentSemester:";
            // 
            // uxTeacherInfoLabel
            // 
            this.uxTeacherInfoLabel.AutoSize = true;
            this.uxTeacherInfoLabel.Location = new System.Drawing.Point(9, 24);
            this.uxTeacherInfoLabel.Name = "uxTeacherInfoLabel";
            this.uxTeacherInfoLabel.Size = new System.Drawing.Size(209, 17);
            this.uxTeacherInfoLabel.TabIndex = 4;
            this.uxTeacherInfoLabel.Text = "Teacher Name | # of Courses: []";
            // 
            // uxCurrentSemester
            // 
            this.uxCurrentSemester.FormattingEnabled = true;
            this.uxCurrentSemester.Location = new System.Drawing.Point(664, 21);
            this.uxCurrentSemester.Name = "uxCurrentSemester";
            this.uxCurrentSemester.Size = new System.Drawing.Size(121, 24);
            this.uxCurrentSemester.TabIndex = 5;
            this.uxCurrentSemester.SelectedIndexChanged += new System.EventHandler(this.uxCurrentSemester_SelectedIndexChanged);
            // 
            // uxCoursesGB
            // 
            this.uxCoursesGB.Controls.Add(this.uxCoursesTL);
            this.uxCoursesGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCoursesGB.Location = new System.Drawing.Point(3, 74);
            this.uxCoursesGB.Name = "uxCoursesGB";
            this.uxCoursesGB.Size = new System.Drawing.Size(178, 373);
            this.uxCoursesGB.TabIndex = 2;
            this.uxCoursesGB.TabStop = false;
            // 
            // uxCoursesTL
            // 
            this.uxCoursesTL.ColumnCount = 1;
            this.uxCoursesTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uxCoursesTL.Controls.Add(this.uxCourses, 0, 1);
            this.uxCoursesTL.Controls.Add(this.uxCoursesLabel, 0, 0);
            this.uxCoursesTL.Controls.Add(this.uxCreateCourse, 0, 2);
            this.uxCoursesTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCoursesTL.Location = new System.Drawing.Point(3, 18);
            this.uxCoursesTL.Name = "uxCoursesTL";
            this.uxCoursesTL.RowCount = 3;
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.38095F));
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uxCoursesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uxCoursesTL.Size = new System.Drawing.Size(172, 352);
            this.uxCoursesTL.TabIndex = 3;
            // 
            // uxCourses
            // 
            this.uxCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCourses.FormattingEnabled = true;
            this.uxCourses.ItemHeight = 25;
            this.uxCourses.Location = new System.Drawing.Point(3, 26);
            this.uxCourses.Name = "uxCourses";
            this.uxCourses.Size = new System.Drawing.Size(166, 282);
            this.uxCourses.TabIndex = 1;
            // 
            // uxCoursesLabel
            // 
            this.uxCoursesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.uxCoursesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCoursesLabel.Location = new System.Drawing.Point(3, 0);
            this.uxCoursesLabel.Name = "uxCoursesLabel";
            this.uxCoursesLabel.Size = new System.Drawing.Size(166, 23);
            this.uxCoursesLabel.TabIndex = 2;
            this.uxCoursesLabel.Text = "Courses";
            this.uxCoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxCreateCourse
            // 
            this.uxCreateCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCreateCourse.Location = new System.Drawing.Point(3, 314);
            this.uxCreateCourse.Name = "uxCreateCourse";
            this.uxCreateCourse.Size = new System.Drawing.Size(166, 35);
            this.uxCreateCourse.TabIndex = 3;
            this.uxCreateCourse.Text = "Create Course";
            this.uxCreateCourse.UseVisualStyleBackColor = true;
            this.uxCreateCourse.Click += new System.EventHandler(this.uxCreateCourse_Click);
            // 
            // uxTabGroupBox
            // 
            this.uxTabGroupBox.Controls.Add(this.uxContentTabs);
            this.uxTabGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTabGroupBox.Location = new System.Drawing.Point(187, 74);
            this.uxTabGroupBox.Name = "uxTabGroupBox";
            this.uxTabGroupBox.Size = new System.Drawing.Size(610, 373);
            this.uxTabGroupBox.TabIndex = 3;
            this.uxTabGroupBox.TabStop = false;
            // 
            // uxContentTabs
            // 
            this.uxContentTabs.Controls.Add(this.uxCourseInfoTab);
            this.uxContentTabs.Controls.Add(this.uxAssignmentsTab);
            this.uxContentTabs.Controls.Add(this.uxStudentsTab);
            this.uxContentTabs.Controls.Add(this.uxReportsTab);
            this.uxContentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxContentTabs.Location = new System.Drawing.Point(3, 18);
            this.uxContentTabs.Name = "uxContentTabs";
            this.uxContentTabs.SelectedIndex = 0;
            this.uxContentTabs.Size = new System.Drawing.Size(604, 352);
            this.uxContentTabs.TabIndex = 1;
            // 
            // uxCourseInfoTab
            // 
            this.uxCourseInfoTab.Controls.Add(this.uxEndDateLabel);
            this.uxCourseInfoTab.Controls.Add(this.uxStartDateLabel);
            this.uxCourseInfoTab.Controls.Add(this.uxNumOfStudentsLabel);
            this.uxCourseInfoTab.Controls.Add(this.uxCourseNameLabel);
            this.uxCourseInfoTab.Location = new System.Drawing.Point(4, 25);
            this.uxCourseInfoTab.Name = "uxCourseInfoTab";
            this.uxCourseInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxCourseInfoTab.Size = new System.Drawing.Size(596, 323);
            this.uxCourseInfoTab.TabIndex = 0;
            this.uxCourseInfoTab.Text = "CourseInfo";
            this.uxCourseInfoTab.UseVisualStyleBackColor = true;
            // 
            // uxEndDateLabel
            // 
            this.uxEndDateLabel.AutoSize = true;
            this.uxEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndDateLabel.Location = new System.Drawing.Point(8, 100);
            this.uxEndDateLabel.Name = "uxEndDateLabel";
            this.uxEndDateLabel.Size = new System.Drawing.Size(138, 29);
            this.uxEndDateLabel.TabIndex = 3;
            this.uxEndDateLabel.Text = "End Date: []";
            // 
            // uxStartDateLabel
            // 
            this.uxStartDateLabel.AutoSize = true;
            this.uxStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartDateLabel.Location = new System.Drawing.Point(8, 71);
            this.uxStartDateLabel.Name = "uxStartDateLabel";
            this.uxStartDateLabel.Size = new System.Drawing.Size(144, 29);
            this.uxStartDateLabel.TabIndex = 2;
            this.uxStartDateLabel.Text = "Start Date: []";
            // 
            // uxNumOfStudentsLabel
            // 
            this.uxNumOfStudentsLabel.AutoSize = true;
            this.uxNumOfStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumOfStudentsLabel.Location = new System.Drawing.Point(8, 42);
            this.uxNumOfStudentsLabel.Name = "uxNumOfStudentsLabel";
            this.uxNumOfStudentsLabel.Size = new System.Drawing.Size(290, 29);
            this.uxNumOfStudentsLabel.TabIndex = 1;
            this.uxNumOfStudentsLabel.Text = "Number Of Students: [] / []";
            // 
            // uxCourseNameLabel
            // 
            this.uxCourseNameLabel.AutoSize = true;
            this.uxCourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCourseNameLabel.Location = new System.Drawing.Point(6, 3);
            this.uxCourseNameLabel.Name = "uxCourseNameLabel";
            this.uxCourseNameLabel.Size = new System.Drawing.Size(230, 38);
            this.uxCourseNameLabel.TabIndex = 0;
            this.uxCourseNameLabel.Text = "Course Name";
            // 
            // uxAssignmentsTab
            // 
            this.uxAssignmentsTab.Controls.Add(this.uxAssignmentsSC);
            this.uxAssignmentsTab.Location = new System.Drawing.Point(4, 25);
            this.uxAssignmentsTab.Name = "uxAssignmentsTab";
            this.uxAssignmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxAssignmentsTab.Size = new System.Drawing.Size(596, 323);
            this.uxAssignmentsTab.TabIndex = 1;
            this.uxAssignmentsTab.Text = "Assignments";
            this.uxAssignmentsTab.UseVisualStyleBackColor = true;
            // 
            // uxAssignmentsSC
            // 
            this.uxAssignmentsSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentsSC.Location = new System.Drawing.Point(3, 3);
            this.uxAssignmentsSC.Name = "uxAssignmentsSC";
            // 
            // uxAssignmentsSC.Panel1
            // 
            this.uxAssignmentsSC.Panel1.Controls.Add(this.uxAssignmentCategoriesTL);
            // 
            // uxAssignmentsSC.Panel2
            // 
            this.uxAssignmentsSC.Panel2.Controls.Add(this.uxAssignmentsTabs2);
            this.uxAssignmentsSC.Size = new System.Drawing.Size(590, 317);
            this.uxAssignmentsSC.SplitterDistance = 161;
            this.uxAssignmentsSC.TabIndex = 0;
            // 
            // uxAssignmentCategoriesTL
            // 
            this.uxAssignmentCategoriesTL.ColumnCount = 1;
            this.uxAssignmentCategoriesTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uxAssignmentCategoriesTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uxAssignmentCategoriesTL.Controls.Add(this.label1, 0, 0);
            this.uxAssignmentCategoriesTL.Controls.Add(this.uxCreateAssignmentCategoryButton, 0, 2);
            this.uxAssignmentCategoriesTL.Controls.Add(this.uxAssignmentCategories, 0, 1);
            this.uxAssignmentCategoriesTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentCategoriesTL.Location = new System.Drawing.Point(0, 0);
            this.uxAssignmentCategoriesTL.Name = "uxAssignmentCategoriesTL";
            this.uxAssignmentCategoriesTL.RowCount = 3;
            this.uxAssignmentCategoriesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.27273F));
            this.uxAssignmentCategoriesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.72727F));
            this.uxAssignmentCategoriesTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.uxAssignmentCategoriesTL.Size = new System.Drawing.Size(161, 317);
            this.uxAssignmentCategoriesTL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assignment Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxCreateAssignmentCategoryButton
            // 
            this.uxCreateAssignmentCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxCreateAssignmentCategoryButton.Location = new System.Drawing.Point(3, 278);
            this.uxCreateAssignmentCategoryButton.Name = "uxCreateAssignmentCategoryButton";
            this.uxCreateAssignmentCategoryButton.Size = new System.Drawing.Size(155, 36);
            this.uxCreateAssignmentCategoryButton.TabIndex = 4;
            this.uxCreateAssignmentCategoryButton.Text = "Create Category";
            this.uxCreateAssignmentCategoryButton.UseVisualStyleBackColor = true;
            this.uxCreateAssignmentCategoryButton.Click += new System.EventHandler(this.uxCreateAssignmentCategoryButton_Click);
            // 
            // uxAssignmentCategories
            // 
            this.uxAssignmentCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentCategories.FormattingEnabled = true;
            this.uxAssignmentCategories.ItemHeight = 16;
            this.uxAssignmentCategories.Location = new System.Drawing.Point(3, 34);
            this.uxAssignmentCategories.Name = "uxAssignmentCategories";
            this.uxAssignmentCategories.Size = new System.Drawing.Size(155, 238);
            this.uxAssignmentCategories.TabIndex = 5;
            // 
            // uxAssignmentsTabs2
            // 
            this.uxAssignmentsTabs2.Controls.Add(this.uxSubmittedAssignmentsTab);
            this.uxAssignmentsTabs2.Controls.Add(this.uxAddRemoveTab);
            this.uxAssignmentsTabs2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentsTabs2.Location = new System.Drawing.Point(0, 0);
            this.uxAssignmentsTabs2.Name = "uxAssignmentsTabs2";
            this.uxAssignmentsTabs2.SelectedIndex = 0;
            this.uxAssignmentsTabs2.Size = new System.Drawing.Size(425, 317);
            this.uxAssignmentsTabs2.TabIndex = 0;
            // 
            // uxSubmittedAssignmentsTab
            // 
            this.uxSubmittedAssignmentsTab.Controls.Add(this.uxAssignmentsSC3);
            this.uxSubmittedAssignmentsTab.Location = new System.Drawing.Point(4, 25);
            this.uxSubmittedAssignmentsTab.Name = "uxSubmittedAssignmentsTab";
            this.uxSubmittedAssignmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxSubmittedAssignmentsTab.Size = new System.Drawing.Size(417, 288);
            this.uxSubmittedAssignmentsTab.TabIndex = 0;
            this.uxSubmittedAssignmentsTab.Text = "Submitted";
            this.uxSubmittedAssignmentsTab.UseVisualStyleBackColor = true;
            // 
            // uxAssignmentsSC3
            // 
            this.uxAssignmentsSC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentsSC3.Location = new System.Drawing.Point(3, 3);
            this.uxAssignmentsSC3.Name = "uxAssignmentsSC3";
            this.uxAssignmentsSC3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // uxAssignmentsSC3.Panel1
            // 
            this.uxAssignmentsSC3.Panel1.Controls.Add(this.uxAssignmentOptions);
            // 
            // uxAssignmentsSC3.Panel2
            // 
            this.uxAssignmentsSC3.Panel2.Controls.Add(this.uxAssignmentsSC2);
            this.uxAssignmentsSC3.Size = new System.Drawing.Size(411, 282);
            this.uxAssignmentsSC3.SplitterDistance = 29;
            this.uxAssignmentsSC3.TabIndex = 1;
            // 
            // uxAssignmentOptions
            // 
            this.uxAssignmentOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentOptions.FormattingEnabled = true;
            this.uxAssignmentOptions.Location = new System.Drawing.Point(0, 0);
            this.uxAssignmentOptions.Name = "uxAssignmentOptions";
            this.uxAssignmentOptions.Size = new System.Drawing.Size(411, 24);
            this.uxAssignmentOptions.TabIndex = 0;
            // 
            // uxAssignmentsSC2
            // 
            this.uxAssignmentsSC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentsSC2.Location = new System.Drawing.Point(0, 0);
            this.uxAssignmentsSC2.Name = "uxAssignmentsSC2";
            this.uxAssignmentsSC2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // uxAssignmentsSC2.Panel1
            // 
            this.uxAssignmentsSC2.Panel1.Controls.Add(this.uxAssignments);
            // 
            // uxAssignmentsSC2.Panel2
            // 
            this.uxAssignmentsSC2.Panel2.Controls.Add(this.uxGradeAssignmentButton);
            this.uxAssignmentsSC2.Size = new System.Drawing.Size(411, 249);
            this.uxAssignmentsSC2.SplitterDistance = 208;
            this.uxAssignmentsSC2.TabIndex = 1;
            // 
            // uxAssignments
            // 
            this.uxAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignments.FormattingEnabled = true;
            this.uxAssignments.ItemHeight = 16;
            this.uxAssignments.Location = new System.Drawing.Point(0, 0);
            this.uxAssignments.Name = "uxAssignments";
            this.uxAssignments.Size = new System.Drawing.Size(411, 208);
            this.uxAssignments.TabIndex = 0;
            // 
            // uxGradeAssignmentButton
            // 
            this.uxGradeAssignmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxGradeAssignmentButton.Location = new System.Drawing.Point(0, 0);
            this.uxGradeAssignmentButton.Name = "uxGradeAssignmentButton";
            this.uxGradeAssignmentButton.Size = new System.Drawing.Size(411, 37);
            this.uxGradeAssignmentButton.TabIndex = 0;
            this.uxGradeAssignmentButton.Text = "Grade Assignment";
            this.uxGradeAssignmentButton.UseVisualStyleBackColor = true;
            this.uxGradeAssignmentButton.Click += new System.EventHandler(this.uxGradeAssignmentButton_Click);
            // 
            // uxAddRemoveTab
            // 
            this.uxAddRemoveTab.Controls.Add(this.uxAssignmentTL);
            this.uxAddRemoveTab.Location = new System.Drawing.Point(4, 25);
            this.uxAddRemoveTab.Name = "uxAddRemoveTab";
            this.uxAddRemoveTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxAddRemoveTab.Size = new System.Drawing.Size(417, 288);
            this.uxAddRemoveTab.TabIndex = 1;
            this.uxAddRemoveTab.Text = "Add/Remove";
            this.uxAddRemoveTab.UseVisualStyleBackColor = true;
            // 
            // uxAssignmentTL
            // 
            this.uxAssignmentTL.ColumnCount = 2;
            this.uxAssignmentTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uxAssignmentTL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uxAssignmentTL.Controls.Add(this.uxARAssignments, 0, 0);
            this.uxAssignmentTL.Controls.Add(this.uxRemoveAssignmentButton);
            this.uxAssignmentTL.Controls.Add(this.uxAddAssignmentButton, 1, 1);
            this.uxAssignmentTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAssignmentTL.Location = new System.Drawing.Point(3, 3);
            this.uxAssignmentTL.Name = "uxAssignmentTL";
            this.uxAssignmentTL.RowCount = 2;
            this.uxAssignmentTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.10638F));
            this.uxAssignmentTL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.uxAssignmentTL.Size = new System.Drawing.Size(411, 282);
            this.uxAssignmentTL.TabIndex = 0;
            // 
            // uxARAssignments
            // 
            this.uxAssignmentTL.SetColumnSpan(this.uxARAssignments, 2);
            this.uxARAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxARAssignments.FormattingEnabled = true;
            this.uxARAssignments.ItemHeight = 16;
            this.uxARAssignments.Location = new System.Drawing.Point(3, 3);
            this.uxARAssignments.Name = "uxARAssignments";
            this.uxARAssignments.Size = new System.Drawing.Size(405, 233);
            this.uxARAssignments.TabIndex = 0;
            // 
            // uxRemoveAssignmentButton
            // 
            this.uxRemoveAssignmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxRemoveAssignmentButton.Location = new System.Drawing.Point(3, 242);
            this.uxRemoveAssignmentButton.Name = "uxRemoveAssignmentButton";
            this.uxRemoveAssignmentButton.Size = new System.Drawing.Size(199, 37);
            this.uxRemoveAssignmentButton.TabIndex = 1;
            this.uxRemoveAssignmentButton.Text = "Remove";
            this.uxRemoveAssignmentButton.UseVisualStyleBackColor = true;
            this.uxRemoveAssignmentButton.Click += new System.EventHandler(this.uxRemoveAssignmentButton_Click);
            // 
            // uxAddAssignmentButton
            // 
            this.uxAddAssignmentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxAddAssignmentButton.Location = new System.Drawing.Point(208, 242);
            this.uxAddAssignmentButton.Name = "uxAddAssignmentButton";
            this.uxAddAssignmentButton.Size = new System.Drawing.Size(200, 37);
            this.uxAddAssignmentButton.TabIndex = 2;
            this.uxAddAssignmentButton.Text = "Add";
            this.uxAddAssignmentButton.UseVisualStyleBackColor = true;
            this.uxAddAssignmentButton.Click += new System.EventHandler(this.uxAddAssignmentButton_Click);
            // 
            // uxStudentsTab
            // 
            this.uxStudentsTab.Controls.Add(this.uxStudents);
            this.uxStudentsTab.Location = new System.Drawing.Point(4, 25);
            this.uxStudentsTab.Name = "uxStudentsTab";
            this.uxStudentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxStudentsTab.Size = new System.Drawing.Size(596, 323);
            this.uxStudentsTab.TabIndex = 2;
            this.uxStudentsTab.Text = "Students";
            this.uxStudentsTab.UseVisualStyleBackColor = true;
            // 
            // uxStudents
            // 
            this.uxStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxStudents.FormattingEnabled = true;
            this.uxStudents.ItemHeight = 16;
            this.uxStudents.Location = new System.Drawing.Point(3, 3);
            this.uxStudents.Name = "uxStudents";
            this.uxStudents.Size = new System.Drawing.Size(590, 317);
            this.uxStudents.TabIndex = 0;
            // 
            // uxReportsTab
            // 
            this.uxReportsTab.Controls.Add(this.uxReportsSC);
            this.uxReportsTab.Location = new System.Drawing.Point(4, 25);
            this.uxReportsTab.Name = "uxReportsTab";
            this.uxReportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxReportsTab.Size = new System.Drawing.Size(596, 323);
            this.uxReportsTab.TabIndex = 3;
            this.uxReportsTab.Text = "Reports";
            this.uxReportsTab.UseVisualStyleBackColor = true;
            // 
            // uxReportsSC
            // 
            this.uxReportsSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxReportsSC.Location = new System.Drawing.Point(3, 3);
            this.uxReportsSC.Name = "uxReportsSC";
            this.uxReportsSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // uxReportsSC.Panel1
            // 
            this.uxReportsSC.Panel1.Controls.Add(this.uxReportOptions);
            // 
            // uxReportsSC.Panel2
            // 
            this.uxReportsSC.Panel2.Controls.Add(this.uxReports);
            this.uxReportsSC.Size = new System.Drawing.Size(590, 317);
            this.uxReportsSC.SplitterDistance = 26;
            this.uxReportsSC.TabIndex = 0;
            // 
            // uxReportOptions
            // 
            this.uxReportOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxReportOptions.FormattingEnabled = true;
            this.uxReportOptions.Location = new System.Drawing.Point(0, 0);
            this.uxReportOptions.Name = "uxReportOptions";
            this.uxReportOptions.Size = new System.Drawing.Size(590, 24);
            this.uxReportOptions.TabIndex = 0;
            // 
            // uxReports
            // 
            this.uxReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxReports.Location = new System.Drawing.Point(0, 0);
            this.uxReports.Name = "uxReports";
            this.uxReports.RowHeadersWidth = 51;
            this.uxReports.RowTemplate.Height = 24;
            this.uxReports.Size = new System.Drawing.Size(590, 287);
            this.uxReports.TabIndex = 0;
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTL1);
            this.Name = "TeacherView";
            this.Text = "TeacherView";
            this.uxTL1.ResumeLayout(false);
            this.uxTeacherInfoGB.ResumeLayout(false);
            this.uxTeacherInfoGB.PerformLayout();
            this.uxCoursesGB.ResumeLayout(false);
            this.uxCoursesTL.ResumeLayout(false);
            this.uxTabGroupBox.ResumeLayout(false);
            this.uxContentTabs.ResumeLayout(false);
            this.uxCourseInfoTab.ResumeLayout(false);
            this.uxCourseInfoTab.PerformLayout();
            this.uxAssignmentsTab.ResumeLayout(false);
            this.uxAssignmentsSC.Panel1.ResumeLayout(false);
            this.uxAssignmentsSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxAssignmentsSC)).EndInit();
            this.uxAssignmentsSC.ResumeLayout(false);
            this.uxAssignmentCategoriesTL.ResumeLayout(false);
            this.uxAssignmentsTabs2.ResumeLayout(false);
            this.uxSubmittedAssignmentsTab.ResumeLayout(false);
            this.uxAssignmentsSC3.Panel1.ResumeLayout(false);
            this.uxAssignmentsSC3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxAssignmentsSC3)).EndInit();
            this.uxAssignmentsSC3.ResumeLayout(false);
            this.uxAssignmentsSC2.Panel1.ResumeLayout(false);
            this.uxAssignmentsSC2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxAssignmentsSC2)).EndInit();
            this.uxAssignmentsSC2.ResumeLayout(false);
            this.uxAddRemoveTab.ResumeLayout(false);
            this.uxAssignmentTL.ResumeLayout(false);
            this.uxStudentsTab.ResumeLayout(false);
            this.uxReportsTab.ResumeLayout(false);
            this.uxReportsSC.Panel1.ResumeLayout(false);
            this.uxReportsSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxReportsSC)).EndInit();
            this.uxReportsSC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uxTL1;
        private System.Windows.Forms.GroupBox uxTeacherInfoGB;
        private System.Windows.Forms.Label uxCurrentSemesterLabel;
        private System.Windows.Forms.Label uxTeacherInfoLabel;
        private System.Windows.Forms.ComboBox uxCurrentSemester;
        private System.Windows.Forms.GroupBox uxCoursesGB;
        private System.Windows.Forms.TableLayoutPanel uxCoursesTL;
        private System.Windows.Forms.ListBox uxCourses;
        private System.Windows.Forms.Label uxCoursesLabel;
        private System.Windows.Forms.Button uxCreateCourse;
        private System.Windows.Forms.GroupBox uxTabGroupBox;
        private System.Windows.Forms.TabControl uxContentTabs;
        private System.Windows.Forms.TabPage uxCourseInfoTab;
        private System.Windows.Forms.TabPage uxAssignmentsTab;
        private System.Windows.Forms.TabPage uxStudentsTab;
        private System.Windows.Forms.Label uxEndDateLabel;
        private System.Windows.Forms.Label uxStartDateLabel;
        private System.Windows.Forms.Label uxNumOfStudentsLabel;
        private System.Windows.Forms.Label uxCourseNameLabel;
        private System.Windows.Forms.SplitContainer uxAssignmentsSC;
        private System.Windows.Forms.ListBox uxStudents;
        private System.Windows.Forms.TableLayoutPanel uxAssignmentCategoriesTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxCreateAssignmentCategoryButton;
        private System.Windows.Forms.ListBox uxAssignmentCategories;
        private System.Windows.Forms.TabPage uxReportsTab;
        private System.Windows.Forms.SplitContainer uxReportsSC;
        private System.Windows.Forms.ComboBox uxReportOptions;
        private System.Windows.Forms.TabControl uxAssignmentsTabs2;
        private System.Windows.Forms.TabPage uxSubmittedAssignmentsTab;
        private System.Windows.Forms.TabPage uxAddRemoveTab;
        private System.Windows.Forms.SplitContainer uxAssignmentsSC3;
        private System.Windows.Forms.ComboBox uxAssignmentOptions;
        private System.Windows.Forms.SplitContainer uxAssignmentsSC2;
        private System.Windows.Forms.ListBox uxAssignments;
        private System.Windows.Forms.Button uxGradeAssignmentButton;
        private System.Windows.Forms.TableLayoutPanel uxAssignmentTL;
        private System.Windows.Forms.ListBox uxARAssignments;
        private System.Windows.Forms.Button uxRemoveAssignmentButton;
        private System.Windows.Forms.Button uxAddAssignmentButton;
        private System.Windows.Forms.DataGridView uxReports;
    }
}