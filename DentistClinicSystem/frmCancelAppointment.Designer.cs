namespace DentistClinicSystem
{
    partial class frmCancelAppointment
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
            btnCancel = new Button();
            cmbCancelAppointment = new ComboBox();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(cmbCancelAppointment);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(27, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 390);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose appointment to cancel:";
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.HotTrack;
            btnCancel.Location = new Point(26, 162);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(187, 59);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbCancelAppointment
            // 
            cmbCancelAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCancelAppointment.FormattingEnabled = true;
            cmbCancelAppointment.Items.AddRange(new object[] { "00001" });
            cmbCancelAppointment.Location = new Point(21, 62);
            cmbCancelAppointment.Name = "cmbCancelAppointment";
            cmbCancelAppointment.Size = new Size(192, 33);
            cmbCancelAppointment.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(702, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCancelAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "frmCancelAppointment";
            Text = "Dentist Clinic System - [CancelAppointment]";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancel;
        private ComboBox cmbCancelAppointment;
        private Button btnExit;
    }
}