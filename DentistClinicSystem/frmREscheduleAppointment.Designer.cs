namespace DentistClinicSystem
{
    partial class frmRescheduleAppointment
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
            btnSave = new Button();
            btnExit = new Button();
            label3 = new Label();
            dtpAppointmentDate = new DateTimePicker();
            grpRescheduleAppointment = new GroupBox();
            btnReschedule = new Button();
            grpUpdate = new GroupBox();
            dtpSearch = new DateTimePicker();
            grdAppointments = new DataGridView();
            btnSearch = new Button();
            grpRescheduleAppointment.SuspendLayout();
            grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAppointments).BeginInit();
            SuspendLayout();
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
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(1088, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 104);
            label3.Name = "label3";
            label3.Size = new Size(171, 23);
            label3.TabIndex = 23;
            label3.Text = "Appointment Date:";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(197, 104);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 30);
            dtpAppointmentDate.TabIndex = 24;
            dtpAppointmentDate.Value = new DateTime(2026, 4, 18, 0, 0, 0, 0);
            // 
            // grpRescheduleAppointment
            // 
            grpRescheduleAppointment.Controls.Add(btnReschedule);
            grpRescheduleAppointment.Controls.Add(dtpAppointmentDate);
            grpRescheduleAppointment.Controls.Add(label3);
            grpRescheduleAppointment.Controls.Add(btnSave);
            grpRescheduleAppointment.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpRescheduleAppointment.ForeColor = SystemColors.HotTrack;
            grpRescheduleAppointment.Location = new Point(44, 399);
            grpRescheduleAppointment.Name = "grpRescheduleAppointment";
            grpRescheduleAppointment.RightToLeft = RightToLeft.No;
            grpRescheduleAppointment.Size = new Size(1083, 260);
            grpRescheduleAppointment.TabIndex = 3;
            grpRescheduleAppointment.TabStop = false;
            grpRescheduleAppointment.Text = "Choose the Appointment Date:";
            grpRescheduleAppointment.Visible = false;
            // 
            // btnReschedule
            // 
            btnReschedule.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReschedule.ForeColor = SystemColors.HotTrack;
            btnReschedule.Location = new Point(251, 164);
            btnReschedule.Name = "btnReschedule";
            btnReschedule.Size = new Size(196, 56);
            btnReschedule.TabIndex = 26;
            btnReschedule.Text = "Reschedule";
            btnReschedule.UseVisualStyleBackColor = true;
            btnReschedule.Click += btnReschedule_Click;
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(dtpSearch);
            grpUpdate.Controls.Add(grdAppointments);
            grpUpdate.Controls.Add(btnSearch);
            grpUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdate.ForeColor = SystemColors.HotTrack;
            grpUpdate.Location = new Point(41, 65);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(1086, 272);
            grpUpdate.TabIndex = 23;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Enter appointment date:";
            // 
            // dtpSearch
            // 
            dtpSearch.Location = new Point(40, 39);
            dtpSearch.Name = "dtpSearch";
            dtpSearch.Size = new Size(250, 30);
            dtpSearch.TabIndex = 25;
            dtpSearch.Value = new DateTime(2026, 4, 18, 0, 0, 0, 0);
            // 
            // grdAppointments
            // 
            grdAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAppointments.Location = new Point(40, 110);
            grdAppointments.Name = "grdAppointments";
            grdAppointments.RowHeadersWidth = 51;
            grdAppointments.Size = new Size(668, 121);
            grdAppointments.TabIndex = 15;
            grdAppointments.Visible = false;
            grdAppointments.CellContentClick += grdAppointments_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.HotTrack;
            btnSearch.Location = new Point(462, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 48);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmRescheduleAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 683);
            Controls.Add(grpUpdate);
            Controls.Add(grpRescheduleAppointment);
            Controls.Add(btnExit);
            Name = "frmRescheduleAppointment";
            Text = "Dentist Clinic System - [Reschedule Appointment]";
            Load += frmRescheduleAppointment_Load;
            grpRescheduleAppointment.ResumeLayout(false);
            grpRescheduleAppointment.PerformLayout();
            grpUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnExit;
        private Label label3;
        private DateTimePicker dtpAppointmentDate;
        private GroupBox grpRescheduleAppointment;
        private Button btnReschedule;
        private GroupBox grpUpdate;
        private DataGridView grdAppointments;
        private Button btnSearch;
        private DateTimePicker dtpSearch;
    }
}