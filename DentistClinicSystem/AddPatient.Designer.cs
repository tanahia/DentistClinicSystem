namespace DentistClinicSystem
{
    partial class frmAddPatient
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
            grpAddDentist = new GroupBox();
            dtpDateofBirth = new DateTimePicker();
            txtAllergies = new TextBox();
            label7 = new Label();
            txtDentalProblems = new TextBox();
            label6 = new Label();
            txtHealthProblems = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            btnExit = new Button();
            label5 = new Label();
            txtPatientID = new TextBox();
            grpAddDentist.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddDentist
            // 
            grpAddDentist.Controls.Add(dtpDateofBirth);
            grpAddDentist.Controls.Add(txtAllergies);
            grpAddDentist.Controls.Add(label7);
            grpAddDentist.Controls.Add(txtDentalProblems);
            grpAddDentist.Controls.Add(label6);
            grpAddDentist.Controls.Add(txtHealthProblems);
            grpAddDentist.Controls.Add(label4);
            grpAddDentist.Controls.Add(btnSave);
            grpAddDentist.Controls.Add(txtAddress);
            grpAddDentist.Controls.Add(txtPhone);
            grpAddDentist.Controls.Add(txtFullName);
            grpAddDentist.Controls.Add(label3);
            grpAddDentist.Controls.Add(label2);
            grpAddDentist.Controls.Add(label1);
            grpAddDentist.Controls.Add(lblFullName);
            grpAddDentist.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddDentist.ForeColor = SystemColors.HotTrack;
            grpAddDentist.Location = new Point(26, 105);
            grpAddDentist.Name = "grpAddDentist";
            grpAddDentist.RightToLeft = RightToLeft.No;
            grpAddDentist.Size = new Size(747, 690);
            grpAddDentist.TabIndex = 1;
            grpAddDentist.TabStop = false;
            grpAddDentist.Text = "Enter the Details:";
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(180, 227);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(250, 30);
            dtpDateofBirth.TabIndex = 18;
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(181, 538);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(250, 58);
            txtAllergies.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 538);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 17;
            label7.Text = "Allergies:";
            // 
            // txtDentalProblems
            // 
            txtDentalProblems.Location = new Point(180, 412);
            txtDentalProblems.Multiline = true;
            txtDentalProblems.Name = "txtDentalProblems";
            txtDentalProblems.Size = new Size(251, 103);
            txtDentalProblems.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 412);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 15;
            label6.Text = "Dental Problems:";
            // 
            // txtHealthProblems
            // 
            txtHealthProblems.Location = new Point(180, 288);
            txtHealthProblems.Multiline = true;
            txtHealthProblems.Name = "txtHealthProblems";
            txtHealthProblems.Size = new Size(251, 103);
            txtHealthProblems.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 288);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 9;
            label4.Text = "Health Problems:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HotTrack;
            btnSave.Location = new Point(180, 614);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 56);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 178);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(247, 30);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(183, 128);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(151, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(183, 80);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(151, 30);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 227);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 178);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Home Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 128);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(20, 80);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name: ";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(701, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(39, 44);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 10;
            label5.Text = "Patient ID: ";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(186, 44);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(125, 27);
            txtPatientID.TabIndex = 11;
            // 
            // frmAddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 873);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(grpAddDentist);
            Controls.Add(txtPatientID);
            Name = "frmAddPatient";
            Text = "Dentist Clinic System - [AddPatient]";
            Load += frmAddPatient_Load;
            grpAddDentist.ResumeLayout(false);
            grpAddDentist.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAddDentist;
        private Button btnSave;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblFullName;
        private TextBox txtHealthProblems;
        private Label label4;
        private TextBox txtDentalProblems;
        private Label label6;
        private TextBox txtAllergies;
        private Label label7;
        private Button btnExit;
        private DateTimePicker dtpDateofBirth;
        private Label label5;
        private TextBox txtPatientID;
    }
}