namespace DentistClinicSystem
{
    partial class frmMakeAppointment
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
            dtpAppointmentDate = new DateTimePicker();
            label3 = new Label();
            btnExit = new Button();
            btnSave = new Button();
            txtComplaint = new TextBox();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            txtServiceTitle = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            txtDentistFullName = new TextBox();
            label2 = new Label();
            grpMakeAppointment.SuspendLayout();
            SuspendLayout();
            // 
            // grpMakeAppointment
            // 
            grpMakeAppointment.Controls.Add(dtpAppointmentDate);
            grpMakeAppointment.Controls.Add(label3);
            grpMakeAppointment.Controls.Add(btnExit);
            grpMakeAppointment.Controls.Add(btnSave);
            grpMakeAppointment.Controls.Add(txtServiceTitle);
            grpMakeAppointment.Controls.Add(label5);
            grpMakeAppointment.Controls.Add(txtComplaint);
            grpMakeAppointment.Controls.Add(label4);
            grpMakeAppointment.Controls.Add(txtDentistFullName);
            grpMakeAppointment.Controls.Add(txtPhone);
            grpMakeAppointment.Controls.Add(txtFullName);
            grpMakeAppointment.Controls.Add(label2);
            grpMakeAppointment.Controls.Add(label1);
            grpMakeAppointment.Controls.Add(lblFullName);
            grpMakeAppointment.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMakeAppointment.ForeColor = SystemColors.HotTrack;
            grpMakeAppointment.Location = new Point(22, 22);
            grpMakeAppointment.Name = "grpMakeAppointment";
            grpMakeAppointment.RightToLeft = RightToLeft.No;
            grpMakeAppointment.Size = new Size(755, 595);
            grpMakeAppointment.TabIndex = 2;
            grpMakeAppointment.TabStop = false;
            grpMakeAppointment.Text = "Enter the Details:";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(195, 244);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 30);
            dtpAppointmentDate.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 244);
            label3.Name = "label3";
            label3.Size = new Size(171, 23);
            label3.TabIndex = 23;
            label3.Text = "Appointment Date:";
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
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HotTrack;
            btnSave.Location = new Point(196, 458);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 56);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtComplaint
            // 
            txtComplaint.Location = new Point(194, 294);
            txtComplaint.Multiline = true;
            txtComplaint.Name = "txtComplaint";
            txtComplaint.Size = new Size(241, 103);
            txtComplaint.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 294);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 9;
            label4.Text = "Complaint:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 193);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 19;
            label5.Text = "Service Title:";
            // 
            // txtServiceTitle
            // 
            txtServiceTitle.Location = new Point(196, 193);
            txtServiceTitle.Name = "txtServiceTitle";
            txtServiceTitle.Size = new Size(150, 30);
            txtServiceTitle.TabIndex = 20;
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
            // txtFullName
            // 
            txtFullName.Location = new Point(195, 40);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(151, 30);
            txtFullName.TabIndex = 1;
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
            // txtPhone
            // 
            txtPhone.Location = new Point(196, 91);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(151, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtDentistFullName
            // 
            txtDentistFullName.Location = new Point(195, 141);
            txtDentistFullName.Name = "txtDentistFullName";
            txtDentistFullName.Size = new Size(151, 30);
            txtDentistFullName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 141);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 2;
            label2.Text = "Dentist Full Name:";
            // 
            // frmMakeAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 643);
            Controls.Add(grpMakeAppointment);
            Name = "frmMakeAppointment";
            Text = "Dentist Clinic System - [Make Appointment]";
            grpMakeAppointment.ResumeLayout(false);
            grpMakeAppointment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMakeAppointment;
        private TextBox txtComplaint;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSave;
        private Button btnExit;
        private DateTimePicker dtpAppointmentDate;
        private Label label3;
        private TextBox txtServiceTitle;
        private Label label5;
        private TextBox txtDentistFullName;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label2;
        private Label label1;
        private Label lblFullName;
    }
}