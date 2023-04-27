namespace SchoolGradeMonitor
{
    partial class FormStudentGrades
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
            this.DgvStudentGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStudentGrades
            // 
            this.DgvStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudentGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStudentGrades.Location = new System.Drawing.Point(0, 0);
            this.DgvStudentGrades.Name = "DgvStudentGrades";
            this.DgvStudentGrades.ReadOnly = true;
            this.DgvStudentGrades.Size = new System.Drawing.Size(800, 450);
            this.DgvStudentGrades.TabIndex = 0;
            // 
            // FormStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvStudentGrades);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentGrades";
            this.Text = " Student Grades";
            this.Load += new System.EventHandler(this.FormStudentGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStudentGrades;
    }
}