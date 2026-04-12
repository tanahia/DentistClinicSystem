namespace DentistClinicSystem
{
    partial class frmUpdatePatientInformation
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
            grpPatients = new GroupBox();
            dtpDateofBirth = new DateTimePicker();
            txtAllergies = new TextBox();
            label7 = new Label();
            txtDentalProblems = new TextBox();
            label6 = new Label();
            txtHealthProblems = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            btnExit = new Button();
            grpUpdate = new GroupBox();
            grdPatients = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            grpPatients.SuspendLayout();
            grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPatients).BeginInit();
            SuspendLayout();
            // 
            // grpPatients
            // 
            grpPatients.Controls.Add(dtpDateofBirth);
            grpPatients.Controls.Add(txtAllergies);
            grpPatients.Controls.Add(label7);
            grpPatients.Controls.Add(txtDentalProblems);
            grpPatients.Controls.Add(label6);
            grpPatients.Controls.Add(txtHealthProblems);
            grpPatients.Controls.Add(label4);
            grpPatients.Controls.Add(btnUpdate);
            grpPatients.Controls.Add(txtAddress);
            grpPatients.Controls.Add(txtPhone);
            grpPatients.Controls.Add(txtFullName);
            grpPatients.Controls.Add(label3);
            grpPatients.Controls.Add(label2);
            grpPatients.Controls.Add(label1);
            grpPatients.Controls.Add(lblFullName);
            grpPatients.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPatients.ForeColor = SystemColors.HotTrack;
            grpPatients.Location = new Point(30, 298);
            grpPatients.Name = "grpPatients";
            grpPatients.RightToLeft = RightToLeft.No;
            grpPatients.Size = new Size(981, 643);
            grpPatients.TabIndex = 2;
            grpPatients.TabStop = false;
            grpPatients.Text = "Choose patient to update:";
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(180, 193);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(250, 30);
            dtpDateofBirth.TabIndex = 20;
            dtpDateofBirth.Value = new DateTime(2026, 4, 12, 0, 0, 0, 0);
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(181, 496);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(196, 58);
            txtAllergies.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 496);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 17;
            label7.Text = "Allergies:";
            // 
            // txtDentalProblems
            // 
            txtDentalProblems.Location = new Point(180, 370);
            txtDentalProblems.Multiline = true;
            txtDentalProblems.Name = "txtDentalProblems";
            txtDentalProblems.Size = new Size(196, 103);
            txtDentalProblems.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 370);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 15;
            label6.Text = "Dental Problems:";
            // 
            // txtHealthProblems
            // 
            txtHealthProblems.Location = new Point(180, 246);
            txtHealthProblems.Multiline = true;
            txtHealthProblems.Name = "txtHealthProblems";
            txtHealthProblems.Size = new Size(196, 103);
            txtHealthProblems.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 246);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 9;
            label4.Text = "Health Problems:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Location = new Point(180, 572);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 56);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 144);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(246, 30);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(184, 94);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(141, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(184, 46);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(141, 30);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 193);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Home Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 94);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(21, 46);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name: ";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(939, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(grdPatients);
            grpUpdate.Controls.Add(txtSearch);
            grpUpdate.Controls.Add(btnSearch);
            grpUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdate.ForeColor = SystemColors.HotTrack;
            grpUpdate.Location = new Point(30, 12);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(747, 272);
            grpUpdate.TabIndex = 21;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Enter Patient Name:";
            // 
            // grdPatients
            // 
            grdPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPatients.Location = new Point(40, 110);
            grdPatients.Name = "grdPatients";
            grdPatients.RowHeadersWidth = 51;
            grdPatients.Size = new Size(668, 121);
            grdPatients.TabIndex = 15;
            grdPatients.Visible = false;
            grdPatients.CellContentClick += grdPatients_CellContentClick;
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
            // frmUpdatePatientInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 953);
            Controls.Add(grpUpdate);
            Controls.Add(btnExit);
            Controls.Add(grpPatients);
            Name = "frmUpdatePatientInformation";
            Text = "Dentist Clinic System - [Update Patient Information]";
            grpPatients.ResumeLayout(false);
            grpPatients.PerformLayout();
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPatients;
        private TextBox txtAllergies;
        private Label label7;
        private TextBox txtDentalProblems;
        private Label label6;
        private TextBox txtHealthProblems;
        private Label label4;
        private Button btnUpdate;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblFullName;
        private Button btnExit;
        private DateTimePicker dtpDateofBirth;
        private GroupBox grpUpdate;
        private DataGridView grdPatients;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}