
namespace SchoolDatabaseApp.Forms
{
    partial class CreateAssignmentDialog
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
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxDueDateLabel = new System.Windows.Forms.Label();
            this.uxTotalPointsLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxDueDate = new System.Windows.Forms.DateTimePicker();
            this.uxTotalPoints = new System.Windows.Forms.NumericUpDown();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxTotalPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(12, 15);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(126, 17);
            this.uxNameLabel.TabIndex = 0;
            this.uxNameLabel.Text = "Assignment Name:";
            // 
            // uxDueDateLabel
            // 
            this.uxDueDateLabel.AutoSize = true;
            this.uxDueDateLabel.Location = new System.Drawing.Point(12, 45);
            this.uxDueDateLabel.Name = "uxDueDateLabel";
            this.uxDueDateLabel.Size = new System.Drawing.Size(72, 17);
            this.uxDueDateLabel.TabIndex = 1;
            this.uxDueDateLabel.Text = "Due Date:";
            // 
            // uxTotalPointsLabel
            // 
            this.uxTotalPointsLabel.AutoSize = true;
            this.uxTotalPointsLabel.Location = new System.Drawing.Point(12, 70);
            this.uxTotalPointsLabel.Name = "uxTotalPointsLabel";
            this.uxTotalPointsLabel.Size = new System.Drawing.Size(87, 17);
            this.uxTotalPointsLabel.TabIndex = 2;
            this.uxTotalPointsLabel.Text = "Total Points:";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(146, 12);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(200, 22);
            this.uxName.TabIndex = 3;
            // 
            // uxDueDate
            // 
            this.uxDueDate.Location = new System.Drawing.Point(146, 40);
            this.uxDueDate.Name = "uxDueDate";
            this.uxDueDate.Size = new System.Drawing.Size(200, 22);
            this.uxDueDate.TabIndex = 4;
            // 
            // uxTotalPoints
            // 
            this.uxTotalPoints.Location = new System.Drawing.Point(146, 70);
            this.uxTotalPoints.Name = "uxTotalPoints";
            this.uxTotalPoints.Size = new System.Drawing.Size(200, 22);
            this.uxTotalPoints.TabIndex = 5;
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Location = new System.Drawing.Point(12, 98);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(90, 32);
            this.uxCancelButton.TabIndex = 6;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(256, 98);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(90, 32);
            this.uxAddButton.TabIndex = 7;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // CreateAssignmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 144);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxTotalPoints);
            this.Controls.Add(this.uxDueDate);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxTotalPointsLabel);
            this.Controls.Add(this.uxDueDateLabel);
            this.Controls.Add(this.uxNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateAssignmentDialog";
            this.Text = "CreateAssignmentDialog";
            ((System.ComponentModel.ISupportInitialize)(this.uxTotalPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxDueDateLabel;
        private System.Windows.Forms.Label uxTotalPointsLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.DateTimePicker uxDueDate;
        private System.Windows.Forms.NumericUpDown uxTotalPoints;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Button uxAddButton;
    }
}