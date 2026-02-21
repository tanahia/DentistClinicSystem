namespace DentistClinicSystem
{
    partial class frmMakePrescription
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
            grpMakeAppointment = new GroupBox();
            txtMedicine = new TextBox();
            label3 = new Label();
            btnExit = new Button();
            btnSend = new Button();
            txtPharmacyAddress = new TextBox();
            label5 = new Label();
            txtInstuctions = new TextBox();
            label4 = new Label();
            txtDentistFullName = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            grpMakeAppointment.SuspendLayout();
            SuspendLayout();
            // 
            // grpMakeAppointment
            // 
            grpMakeAppointment.Controls.Add(txtMedicine);
            grpMakeAppointment.Controls.Add(label3);
            grpMakeAppointment.Controls.Add(btnExit);
            grpMakeAppointment.Controls.Add(btnSend);
            grpMakeAppointment.Controls.Add(txtPharmacyAddress);
            grpMakeAppointment.Controls.Add(label5);
            grpMakeAppointment.Controls.Add(txtInstuctions);
            grpMakeAppointment.Controls.Add(label4);
            grpMakeAppointment.Controls.Add(txtDentistFullName);
            grpMakeAppointment.Controls.Add(txtPhone);
            grpMakeAppointment.Controls.Add(txtFullName);
            grpMakeAppointment.Controls.Add(label2);
            grpMakeAppointment.Controls.Add(label1);
            grpMakeAppointment.Controls.Add(lblFullName);
            grpMakeAppointment.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMakeAppointment.ForeColor = SystemColors.HotTrack;
            grpMakeAppointment.Location = new Point(23, 12);
            grpMakeAppointment.Name = "grpMakeAppointment";
            grpMakeAppointment.RightToLeft = RightToLeft.No;
            grpMakeAppointment.Size = new Size(755, 509);
            grpMakeAppointment.TabIndex = 3;
            grpMakeAppointment.TabStop = false;
            grpMakeAppointment.Text = "Enter the Details:";
            // 
            // txtMedicine
            // 
            txtMedicine.Location = new Point(193, 56);
            txtMedicine.Name = "txtMedicine";
            txtMedicine.Size = new Size(151, 30);
            txtMedicine.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 59);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 23;
            label3.Text = "Medicine Name: ";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(683, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = SystemColors.HotTrack;
            btnSend.Location = new Point(194, 457);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(196, 56);
            btnSend.TabIndex = 22;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtPharmacyAddress
            // 
            txtPharmacyAddress.Location = new Point(194, 260);
            txtPharmacyAddress.Name = "txtPharmacyAddress";
            txtPharmacyAddress.Size = new Size(150, 30);
            txtPharmacyAddress.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 260);
            label5.Name = "label5";
            label5.Size = new Size(173, 23);
            label5.TabIndex = 19;
            label5.Text = "Pharmacy Address:";
            // 
            // txtInstuctions
            // 
            txtInstuctions.Location = new Point(192, 315);
            txtInstuctions.Multiline = true;
            txtInstuctions.Name = "txtInstuctions";
            txtInstuctions.Size = new Size(241, 103);
            txtInstuctions.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 315);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 9;
            label4.Text = "Instructions:";
            // 
            // txtDentistFullName
            // 
            txtDentistFullName.Location = new Point(193, 208);
            txtDentistFullName.Name = "txtDentistFullName";
            txtDentistFullName.Size = new Size(151, 30);
            txtDentistFullName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(194, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(151, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(193, 107);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(151, 30);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 208);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 2;
            label2.Text = "Dentist Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 158);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(19, 110);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name: ";
            // 
            // frmMakePrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(grpMakeAppointment);
            Name = "frmMakePrescription";
            Text = "Dentist Clinic System - [Make Prescription]";
            grpMakeAppointment.ResumeLayout(false);
            grpMakeAppointment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMakeAppointment;
        private Button btnExit;
        private Button btnSend;
        private TextBox txtPharmacyAddress;
        private Label label5;
        private TextBox txtInstuctions;
        private Label label4;
        private TextBox txtDentistFullName;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label2;
        private Label label1;
        private Label lblFullName;
        private TextBox txtMedicine;
        private Label label3;
    }
}