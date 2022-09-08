
namespace SchoolDatabaseApp.Forms
{
    partial class CreateCourseDialog
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
            this.uxCourseNameLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCourseNameLabel
            // 
            this.uxCourseNameLabel.AutoSize = true;
            this.uxCourseNameLabel.Location = new System.Drawing.Point(12, 15);
            this.uxCourseNameLabel.Name = "uxCourseNameLabel";
            this.uxCourseNameLabel.Size = new System.Drawing.Size(98, 17);
            this.uxCourseNameLabel.TabIndex = 0;
            this.uxCourseNameLabel.Text = "Course Name:";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(116, 12);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(141, 22);
            this.uxName.TabIndex = 1;
            this.uxName.TextChanged += new System.EventHandler(this.uxName_TextChanged);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Location = new System.Drawing.Point(12, 68);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(98, 27);
            this.uxCancelButton.TabIndex = 2;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Capacity:";
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(159, 68);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(98, 27);
            this.uxAddButton.TabIndex = 4;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // uxCapacity
            // 
            this.uxCapacity.Location = new System.Drawing.Point(137, 40);
            this.uxCapacity.Name = "uxCapacity";
            this.uxCapacity.Size = new System.Drawing.Size(120, 22);
            this.uxCapacity.TabIndex = 5;
            this.uxCapacity.ValueChanged += new System.EventHandler(this.uxCapacity_ValueChanged);
            // 
            // CreateCourseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 112);
            this.Controls.Add(this.uxCapacity);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxCourseNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateCourseDialog";
            this.Text = "CreateCourseDialog";
            ((System.ComponentModel.ISupportInitialize)(this.uxCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxCourseNameLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.NumericUpDown uxCapacity;
    }
}