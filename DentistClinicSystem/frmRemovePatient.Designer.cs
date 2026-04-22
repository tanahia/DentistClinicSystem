namespace DentistClinicSystem
{
    partial class frmRemovePatient
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
            groupBox1 = new GroupBox();
            grdPatients = new DataGridView();
            txtSearch = new TextBox();
            btnRemove = new Button();
            btnSearch = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPatients).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdPatients);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(43, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(893, 463);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose patient to remove:";
            // 
            // grdPatients
            // 
            grdPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPatients.Location = new Point(28, 128);
            grdPatients.Name = "grdPatients";
            grdPatients.RowHeadersWidth = 51;
            grdPatients.Size = new Size(668, 121);
            grdPatients.TabIndex = 18;
            grdPatients.Visible = false;
            grdPatients.CellContentClick += grdPatients_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 34);
            txtSearch.TabIndex = 17;
            // 
            // btnRemove
            // 
            btnRemove.ForeColor = SystemColors.HotTrack;
            btnRemove.Location = new Point(301, 332);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(187, 59);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.HotTrack;
            btnSearch.Location = new Point(456, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 48);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(864, 32);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmRemovePatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 580);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "frmRemovePatient";
            Text = "Dentist Clinic System -[RemovePatient]";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRemove;
        private Button btnExit;
        private DataGridView grdPatients;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}