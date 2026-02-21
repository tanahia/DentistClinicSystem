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
            grpAddDentist = new GroupBox();
            dtpDateofBirth = new DateTimePicker();
            cmbUpdatePatient = new ComboBox();
            txtAllergies = new TextBox();
            label7 = new Label();
            txtDentalProblems = new TextBox();
            label6 = new Label();
            rbtnOther = new RadioButton();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            label5 = new Label();
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
            grpAddDentist.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddDentist
            // 
            grpAddDentist.Controls.Add(dtpDateofBirth);
            grpAddDentist.Controls.Add(cmbUpdatePatient);
            grpAddDentist.Controls.Add(txtAllergies);
            grpAddDentist.Controls.Add(label7);
            grpAddDentist.Controls.Add(txtDentalProblems);
            grpAddDentist.Controls.Add(label6);
            grpAddDentist.Controls.Add(rbtnOther);
            grpAddDentist.Controls.Add(rbtnMale);
            grpAddDentist.Controls.Add(rbtnFemale);
            grpAddDentist.Controls.Add(label5);
            grpAddDentist.Controls.Add(txtHealthProblems);
            grpAddDentist.Controls.Add(label4);
            grpAddDentist.Controls.Add(btnUpdate);
            grpAddDentist.Controls.Add(txtAddress);
            grpAddDentist.Controls.Add(txtPhone);
            grpAddDentist.Controls.Add(txtFullName);
            grpAddDentist.Controls.Add(label3);
            grpAddDentist.Controls.Add(label2);
            grpAddDentist.Controls.Add(label1);
            grpAddDentist.Controls.Add(lblFullName);
            grpAddDentist.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddDentist.ForeColor = SystemColors.HotTrack;
            grpAddDentist.Location = new Point(29, 26);
            grpAddDentist.Name = "grpAddDentist";
            grpAddDentist.RightToLeft = RightToLeft.No;
            grpAddDentist.Size = new Size(747, 778);
            grpAddDentist.TabIndex = 2;
            grpAddDentist.TabStop = false;
            grpAddDentist.Text = "Choose patient to update:";
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(179, 266);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(250, 30);
            dtpDateofBirth.TabIndex = 20;
            dtpDateofBirth.Value = new DateTime(2025, 11, 24, 0, 0, 0, 0);
            // 
            // cmbUpdatePatient
            // 
            cmbUpdatePatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdatePatient.FormattingEnabled = true;
            cmbUpdatePatient.Items.AddRange(new object[] { "001" });
            cmbUpdatePatient.Location = new Point(20, 49);
            cmbUpdatePatient.Name = "cmbUpdatePatient";
            cmbUpdatePatient.Size = new Size(192, 31);
            cmbUpdatePatient.TabIndex = 19;
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(180, 614);
            txtAllergies.Multiline = true;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(196, 58);
            txtAllergies.TabIndex = 18;
            txtAllergies.Text = "None";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 614);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 17;
            label7.Text = "Allergies:";
            // 
            // txtDentalProblems
            // 
            txtDentalProblems.Location = new Point(179, 488);
            txtDentalProblems.Multiline = true;
            txtDentalProblems.Name = "txtDentalProblems";
            txtDentalProblems.Size = new Size(196, 103);
            txtDentalProblems.TabIndex = 16;
            txtDentalProblems.Text = "Tooth decay";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 488);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 15;
            label6.Text = "Dental Problems:";
            // 
            // rbtnOther
            // 
            rbtnOther.AutoSize = true;
            rbtnOther.Location = new Point(371, 321);
            rbtnOther.Name = "rbtnOther";
            rbtnOther.Size = new Size(76, 27);
            rbtnOther.TabIndex = 14;
            rbtnOther.TabStop = true;
            rbtnOther.Text = "other";
            rbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(275, 321);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(71, 27);
            rbtnMale.TabIndex = 13;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(166, 321);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(88, 27);
            rbtnFemale.TabIndex = 12;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 320);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 11;
            label5.Text = "Sex:";
            // 
            // txtHealthProblems
            // 
            txtHealthProblems.Location = new Point(179, 364);
            txtHealthProblems.Multiline = true;
            txtHealthProblems.Name = "txtHealthProblems";
            txtHealthProblems.Size = new Size(196, 103);
            txtHealthProblems.TabIndex = 10;
            txtHealthProblems.Text = "Nothing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 364);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 9;
            label4.Text = "Health Problems:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Location = new Point(179, 690);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 56);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 217);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(246, 30);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "Street1";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(183, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(141, 30);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "+353";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(183, 119);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(141, 30);
            txtFullName.TabIndex = 1;
            txtFullName.Text = "John Snow";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 266);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 217);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Home Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 167);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(20, 119);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name: ";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(704, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmUpdatePatientInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 832);
            Controls.Add(btnExit);
            Controls.Add(grpAddDentist);
            Name = "frmUpdatePatientInformation";
            Text = "Dentist Clinic System - [Update Patient Information]";
            grpAddDentist.ResumeLayout(false);
            grpAddDentist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddDentist;
        private TextBox txtAllergies;
        private Label label7;
        private TextBox txtDentalProblems;
        private Label label6;
        private RadioButton rbtnOther;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private Label label5;
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
        private ComboBox cmbUpdatePatient;
        private Button btnExit;
        private DateTimePicker dtpDateofBirth;
    }
}