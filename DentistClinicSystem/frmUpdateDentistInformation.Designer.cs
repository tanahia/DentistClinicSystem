namespace DentistClinicSystem
{
    partial class frmUpdateDentistInformation
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
            grpUpdate = new GroupBox();
            grdDentists = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnExit = new Button();
            grpDentists = new GroupBox();
            btnUpdate = new Button();
            txtBio = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdDentists).BeginInit();
            grpDentists.SuspendLayout();
            SuspendLayout();
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(grdDentists);
            grpUpdate.Controls.Add(txtSearch);
            grpUpdate.Controls.Add(btnSearch);
            grpUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdate.ForeColor = SystemColors.HotTrack;
            grpUpdate.Location = new Point(26, 33);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(747, 272);
            grpUpdate.TabIndex = 0;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Enter Dentist Name:";
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
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(701, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpDentists
            // 
            grpDentists.Controls.Add(btnUpdate);
            grpDentists.Controls.Add(txtBio);
            grpDentists.Controls.Add(txtAddress);
            grpDentists.Controls.Add(txtPhone);
            grpDentists.Controls.Add(txtFullName);
            grpDentists.Controls.Add(label3);
            grpDentists.Controls.Add(label2);
            grpDentists.Controls.Add(label1);
            grpDentists.Controls.Add(lblFullName);
            grpDentists.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDentists.ForeColor = SystemColors.HotTrack;
            grpDentists.Location = new Point(26, 328);
            grpDentists.Name = "grpDentists";
            grpDentists.RightToLeft = RightToLeft.No;
            grpDentists.Size = new Size(747, 459);
            grpDentists.TabIndex = 7;
            grpDentists.TabStop = false;
            grpDentists.Text = "Update the Details:";
            grpDentists.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Location = new Point(164, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 56);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(168, 190);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(196, 96);
            txtBio.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(168, 141);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(192, 30);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 84);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(168, 43);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 30);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 190);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 3;
            label3.Text = "Bio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 141);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Home Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 91);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(21, 43);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name: ";
            // 
            // frmUpdateDentistInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 802);
            Controls.Add(grpDentists);
            Controls.Add(btnExit);
            Controls.Add(grpUpdate);
            Name = "frmUpdateDentistInformation";
            Text = "Dentist Clinic System - [Update Dentist Information]";
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdDentists).EndInit();
            grpDentists.ResumeLayout(false);
            grpDentists.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUpdate;
        private Button btnSearch;
        private Button btnExit;
        private DataGridView grdDentists;
        private TextBox txtSearch;
        private GroupBox grpDentists;
        private Button btnUpdate;
        private TextBox txtBio;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblFullName;
    }
}