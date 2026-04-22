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
            dtpSearch = new DateTimePicker();
            grdAppointments = new DataGridView();
            btnSearch = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAppointments).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpSearch);
            groupBox1.Controls.Add(grdAppointments);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(31, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(918, 484);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose appointment to cancel:";
            // 
            // dtpSearch
            // 
            dtpSearch.Location = new Point(40, 59);
            dtpSearch.Name = "dtpSearch";
            dtpSearch.Size = new Size(250, 34);
            dtpSearch.TabIndex = 28;
            dtpSearch.Value = new DateTime(2026, 4, 18, 0, 0, 0, 0);
            // 
            // grdAppointments
            // 
            grdAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAppointments.Location = new Point(40, 130);
            grdAppointments.Name = "grdAppointments";
            grdAppointments.RowHeadersWidth = 51;
            grdAppointments.Size = new Size(668, 121);
            grdAppointments.TabIndex = 27;
            grdAppointments.Visible = false;
            grdAppointments.CellContentClick += grdAppointments_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.HotTrack;
            btnSearch.Location = new Point(462, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 48);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.HotTrack;
            btnCancel.Location = new Point(359, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(187, 59);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(877, 21);
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
            ClientSize = new Size(982, 580);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "frmCancelAppointment";
            Text = "Dentist Clinic System - [CancelAppointment]";
            Load += frmCancelAppointment_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnExit;
        private DateTimePicker dtpSearch;
        private DataGridView grdAppointments;
        private Button btnSearch;
    }
}