namespace DentistClinicSystem
{
    partial class frmRemoveDentist
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
            btnExit = new Button();
            grpRemove = new GroupBox();
            btnRemove = new Button();
            grdDentists = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            grpRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdDentists).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(857, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpRemove
            // 
            grpRemove.Controls.Add(btnRemove);
            grpRemove.Controls.Add(grdDentists);
            grpRemove.Controls.Add(txtSearch);
            grpRemove.Controls.Add(btnSearch);
            grpRemove.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpRemove.ForeColor = SystemColors.HotTrack;
            grpRemove.Location = new Point(40, 63);
            grpRemove.Name = "grpRemove";
            grpRemove.Size = new Size(889, 466);
            grpRemove.TabIndex = 2;
            grpRemove.TabStop = false;
            grpRemove.Text = "Enter Dentist Name:";
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.HotTrack;
            btnRemove.Location = new Point(314, 295);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(242, 73);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // grdDentists
            // 
            grdDentists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDentists.Location = new Point(40, 110);
            grdDentists.Name = "grdDentists";
            grdDentists.RowHeadersWidth = 51;
            grdDentists.Size = new Size(668, 121);
            grdDentists.TabIndex = 15;
            grdDentists.Visible = false;
            grdDentists.CellContentClick += grdDentists_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(92, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 30);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.HotTrack;
            btnSearch.Location = new Point(468, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 48);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmRemoveDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 580);
            Controls.Add(grpRemove);
            Controls.Add(btnExit);
            Name = "frmRemoveDentist";
            Text = "Dentist Clinic System - [Remove Dentist]";
            grpRemove.ResumeLayout(false);
            grpRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdDentists).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnExit;
        private GroupBox grpRemove;
        private DataGridView grdDentists;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRemove;
    }
}