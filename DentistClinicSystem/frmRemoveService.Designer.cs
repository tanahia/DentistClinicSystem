namespace DentistClinicSystem
{
    partial class frmRemoveService
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
            grdServices = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRemove = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdServices).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdServices);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(59, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 562);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose service to remove:";
            // 
            // grdServices
            // 
            grdServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdServices.Location = new Point(58, 118);
            grdServices.Name = "grdServices";
            grdServices.RowHeadersWidth = 51;
            grdServices.Size = new Size(668, 121);
            grdServices.TabIndex = 18;
            grdServices.Visible = false;
            grdServices.CellContentClick += grdServices_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(110, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 34);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.HotTrack;
            btnSearch.Location = new Point(480, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 48);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRemove
            // 
            btnRemove.ForeColor = SystemColors.HotTrack;
            btnRemove.Location = new Point(385, 303);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(187, 59);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(927, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmRemoveService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 636);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "frmRemoveService";
            Text = "Dentist Clinic System - [Remove Service]";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRemove;
        private Button btnExit;
        private DataGridView grdServices;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}