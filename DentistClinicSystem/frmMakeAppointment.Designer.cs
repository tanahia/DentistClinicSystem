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
            components = new System.ComponentModel.Container();
            grpMakeAppointment = new GroupBox();
            txtAppointmentID = new TextBox();
            label2 = new Label();
            cmbPatientName = new ComboBox();
            cmbDentistName = new ComboBox();
            cmbServiceTitle = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            label3 = new Label();
            btnSave = new Button();
            label5 = new Label();
            txtComplaint = new TextBox();
            label4 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            serviceBindingSource = new BindingSource(components);
            btnExit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpMakeAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grpMakeAppointment
            // 
            grpMakeAppointment.Controls.Add(txtAppointmentID);
            grpMakeAppointment.Controls.Add(label2);
            grpMakeAppointment.Controls.Add(cmbPatientName);
            grpMakeAppointment.Controls.Add(cmbDentistName);
            grpMakeAppointment.Controls.Add(cmbServiceTitle);
            grpMakeAppointment.Controls.Add(dtpAppointmentDate);
            grpMakeAppointment.Controls.Add(label3);
            grpMakeAppointment.Controls.Add(btnSave);
            grpMakeAppointment.Controls.Add(label5);
            grpMakeAppointment.Controls.Add(txtComplaint);
            grpMakeAppointment.Controls.Add(label4);
            grpMakeAppointment.Controls.Add(label1);
            grpMakeAppointment.Controls.Add(lblFullName);
            grpMakeAppointment.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMakeAppointment.ForeColor = SystemColors.HotTrack;
            grpMakeAppointment.Location = new Point(22, 49);
            grpMakeAppointment.Name = "grpMakeAppointment";
            grpMakeAppointment.RightToLeft = RightToLeft.No;
            grpMakeAppointment.Size = new Size(932, 492);
            grpMakeAppointment.TabIndex = 2;
            grpMakeAppointment.TabStop = false;
            grpMakeAppointment.Text = "Enter the Details:";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Location = new Point(186, 55);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(61, 30);
            txtAppointmentID.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 25;
            label2.Text = "Appointment ID:";
            // 
            // cmbPatientName
            // 
            cmbPatientName.FormattingEnabled = true;
            cmbPatientName.Location = new Point(187, 100);
            cmbPatientName.Name = "cmbPatientName";
            cmbPatientName.Size = new Size(151, 31);
            cmbPatientName.TabIndex = 22;
            // 
            // cmbDentistName
            // 
            cmbDentistName.FormattingEnabled = true;
            cmbDentistName.Location = new Point(186, 144);
            cmbDentistName.Name = "cmbDentistName";
            cmbDentistName.Size = new Size(151, 31);
            cmbDentistName.TabIndex = 23;
            // 
            // cmbServiceTitle
            // 
            cmbServiceTitle.FormattingEnabled = true;
            cmbServiceTitle.Location = new Point(187, 186);
            cmbServiceTitle.Name = "cmbServiceTitle";
            cmbServiceTitle.Size = new Size(151, 31);
            cmbServiceTitle.TabIndex = 24;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(187, 237);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 30);
            dtpAppointmentDate.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 237);
            label3.Name = "label3";
            label3.Size = new Size(171, 23);
            label3.TabIndex = 23;
            label3.Text = "Appointment Date:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HotTrack;
            btnSave.Location = new Point(187, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 56);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 191);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 19;
            label5.Text = "Service:";
            // 
            // txtComplaint
            // 
            txtComplaint.Location = new Point(186, 287);
            txtComplaint.Multiline = true;
            txtComplaint.Name = "txtComplaint";
            txtComplaint.Size = new Size(241, 103);
            txtComplaint.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 287);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 9;
            label4.Text = "Complaint:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 144);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 1;
            label1.Text = "Dentist:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(21, 103);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(78, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Patient:";
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Service);
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(882, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMakeAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(grpMakeAppointment);
            Controls.Add(btnExit);
            Name = "frmMakeAppointment";
            Text = "Dentist Clinic System - [Make Appointment]";
            Load += frmMakeAppointment_Load;
            grpMakeAppointment.ResumeLayout(false);
            grpMakeAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
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
        private Label label5;
        private Label label1;
        private Label lblFullName;
        private ComboBox cmbPatientName;
        private ComboBox cmbDentistName;
        private ComboBox cmbServiceTitle;
        private TextBox txtAppointmentID;
        private Label label2;
        private BindingSource serviceBindingSource;
    }
}