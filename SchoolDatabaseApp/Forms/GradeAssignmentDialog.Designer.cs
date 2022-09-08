
namespace SchoolDatabaseApp.Forms
{
    partial class GradeAssignmentDialog
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
            this.uxChangeButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxGrade = new System.Windows.Forms.NumericUpDown();
            this.uxGradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // uxChangeButton
            // 
            this.uxChangeButton.Location = new System.Drawing.Point(193, 40);
            this.uxChangeButton.Name = "uxChangeButton";
            this.uxChangeButton.Size = new System.Drawing.Size(90, 32);
            this.uxChangeButton.TabIndex = 0;
            this.uxChangeButton.Text = "Change";
            this.uxChangeButton.UseVisualStyleBackColor = true;
            this.uxChangeButton.Click += new System.EventHandler(this.uxChangeButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Location = new System.Drawing.Point(12, 40);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(90, 32);
            this.uxCancelButton.TabIndex = 1;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxGrade
            // 
            this.uxGrade.Location = new System.Drawing.Point(98, 12);
            this.uxGrade.Name = "uxGrade";
            this.uxGrade.Size = new System.Drawing.Size(185, 22);
            this.uxGrade.TabIndex = 2;
            // 
            // uxGradeLabel
            // 
            this.uxGradeLabel.AutoSize = true;
            this.uxGradeLabel.Location = new System.Drawing.Point(12, 14);
            this.uxGradeLabel.Name = "uxGradeLabel";
            this.uxGradeLabel.Size = new System.Drawing.Size(80, 17);
            this.uxGradeLabel.TabIndex = 3;
            this.uxGradeLabel.Text = "New Score:";
            // 
            // GradeAssignmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 90);
            this.Controls.Add(this.uxGradeLabel);
            this.Controls.Add(this.uxGrade);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxChangeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GradeAssignmentDialog";
            this.Text = "GradeAssignmentDialog";
            ((System.ComponentModel.ISupportInitialize)(this.uxGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxChangeButton;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.NumericUpDown uxGrade;
        private System.Windows.Forms.Label uxGradeLabel;
    }
}