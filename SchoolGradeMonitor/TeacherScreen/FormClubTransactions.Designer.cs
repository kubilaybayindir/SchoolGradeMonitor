namespace SchoolGradeMonitor.TeacherScreen
{
    partial class FormClubTransactions
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
            this.DgvClubs = new System.Windows.Forms.DataGridView();
            this.BtList = new System.Windows.Forms.Button();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.TbxClubId = new System.Windows.Forms.TextBox();
            this.TbxClubName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClubs
            // 
            this.DgvClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClubs.Location = new System.Drawing.Point(9, 12);
            this.DgvClubs.Name = "DgvClubs";
            this.DgvClubs.ReadOnly = true;
            this.DgvClubs.Size = new System.Drawing.Size(323, 207);
            this.DgvClubs.TabIndex = 0;
            this.DgvClubs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClubs_CellClick);
            // 
            // BtList
            // 
            this.BtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtList.Location = new System.Drawing.Point(9, 337);
            this.BtList.Name = "BtList";
            this.BtList.Size = new System.Drawing.Size(151, 46);
            this.BtList.TabIndex = 1;
            this.BtList.Text = "List";
            this.BtList.UseVisualStyleBackColor = true;
            this.BtList.Click += new System.EventHandler(this.BtList_Click);
            // 
            // BtInsert
            // 
            this.BtInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtInsert.Location = new System.Drawing.Point(9, 389);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(151, 46);
            this.BtInsert.TabIndex = 2;
            this.BtInsert.Text = "Insert";
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDelete.Location = new System.Drawing.Point(181, 389);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(151, 46);
            this.BtDelete.TabIndex = 4;
            this.BtDelete.Text = "Delete";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUpdate.Location = new System.Drawing.Point(181, 337);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(151, 46);
            this.BtUpdate.TabIndex = 3;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // TbxClubId
            // 
            this.TbxClubId.Enabled = false;
            this.TbxClubId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxClubId.Location = new System.Drawing.Point(159, 239);
            this.TbxClubId.Name = "TbxClubId";
            this.TbxClubId.ReadOnly = true;
            this.TbxClubId.Size = new System.Drawing.Size(173, 26);
            this.TbxClubId.TabIndex = 5;
            // 
            // TbxClubName
            // 
            this.TbxClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxClubName.Location = new System.Drawing.Point(158, 282);
            this.TbxClubName.Name = "TbxClubName";
            this.TbxClubName.Size = new System.Drawing.Size(173, 26);
            this.TbxClubName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Club Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Club Name:";
            // 
            // FormClubTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxClubName);
            this.Controls.Add(this.TbxClubId);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtInsert);
            this.Controls.Add(this.BtList);
            this.Controls.Add(this.DgvClubs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClubTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Transactions";
            this.Load += new System.EventHandler(this.FormClubTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClubs;
        private System.Windows.Forms.Button BtList;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.TextBox TbxClubId;
        private System.Windows.Forms.TextBox TbxClubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}