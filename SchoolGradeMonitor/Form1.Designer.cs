namespace SchoolGradeMonitor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtGenerator = new System.Windows.Forms.Button();
            this.PbStudent = new System.Windows.Forms.PictureBox();
            this.PbTeacher = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // BtGenerator
            // 
            this.BtGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtGenerator.Location = new System.Drawing.Point(340, 22);
            this.BtGenerator.Name = "BtGenerator";
            this.BtGenerator.Size = new System.Drawing.Size(91, 33);
            this.BtGenerator.TabIndex = 0;
            this.BtGenerator.Text = "Generate";
            this.BtGenerator.UseVisualStyleBackColor = true;
            this.BtGenerator.Click += new System.EventHandler(this.BtGenerator_Click);
            // 
            // PbStudent
            // 
            this.PbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbStudent.Image = ((System.Drawing.Image)(resources.GetObject("PbStudent.Image")));
            this.PbStudent.Location = new System.Drawing.Point(40, 114);
            this.PbStudent.Name = "PbStudent";
            this.PbStudent.Size = new System.Drawing.Size(141, 119);
            this.PbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbStudent.TabIndex = 1;
            this.PbStudent.TabStop = false;
            this.PbStudent.Click += new System.EventHandler(this.PbStudent_Click);
            // 
            // PbTeacher
            // 
            this.PbTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbTeacher.Image = ((System.Drawing.Image)(resources.GetObject("PbTeacher.Image")));
            this.PbTeacher.Location = new System.Drawing.Point(235, 114);
            this.PbTeacher.Name = "PbTeacher";
            this.PbTeacher.Size = new System.Drawing.Size(141, 119);
            this.PbTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbTeacher.TabIndex = 2;
            this.PbTeacher.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "STUDENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "TEACHER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number:";
            // 
            // TbxId
            // 
            this.TbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxId.Location = new System.Drawing.Point(145, 288);
            this.TbxId.Name = "TbxId";
            this.TbxId.Size = new System.Drawing.Size(231, 29);
            this.TbxId.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 370);
            this.Controls.Add(this.TbxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbTeacher);
            this.Controls.Add(this.PbStudent);
            this.Controls.Add(this.BtGenerator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtGenerator;
        private System.Windows.Forms.PictureBox PbStudent;
        private System.Windows.Forms.PictureBox PbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxId;
    }
}

