namespace DentistClinicSystem
{
    partial class frmUpdateServiceInformation
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
            grpServices = new GroupBox();
            txtPrice = new TextBox();
            btnUpdate = new Button();
            txtServiceTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            grpUpdate = new GroupBox();
            grdServices = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            grpServices.SuspendLayout();
            grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdServices).BeginInit();
            SuspendLayout();
            // 
            // grpServices
            // 
            grpServices.Controls.Add(txtPrice);
            grpServices.Controls.Add(btnUpdate);
            grpServices.Controls.Add(txtServiceTitle);
            grpServices.Controls.Add(label2);
            grpServices.Controls.Add(label1);
            grpServices.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpServices.ForeColor = SystemColors.HotTrack;
            grpServices.Location = new Point(49, 378);
            grpServices.Name = "grpServices";
            grpServices.RightToLeft = RightToLeft.No;
            grpServices.Size = new Size(885, 333);
            grpServices.TabIndex = 3;
            grpServices.TabStop = false;
            grpServices.Text = "Update Service Information:";
            grpServices.Visible = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(191, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(53, 30);
            txtPrice.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Location = new Point(191, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 56);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtServiceTitle
            // 
            txtServiceTitle.Location = new Point(191, 53);
            txtServiceTitle.Name = "txtServiceTitle";
            txtServiceTitle.Size = new Size(141, 30);
            txtServiceTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 1;
            label1.Text = "Service Title:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(862, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(grdServices);
            grpUpdate.Controls.Add(txtSearch);
            grpUpdate.Controls.Add(btnSearch);
            grpUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdate.ForeColor = SystemColors.HotTrack;
            grpUpdate.Location = new Point(49, 51);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(885, 295);
            grpUpdate.TabIndex = 22;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Enter Service Title:";
            // 
            // grdServices
            // 
            grdServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdServices.Location = new Point(40, 110);
            grdServices.Name = "grdServices";
            grdServices.RowHeadersWidth = 51;
            grdServices.Size = new Size(668, 121);
            grdServices.TabIndex = 15;
            grdServices.Visible = false;
            grdServices.CellContentClick += grdServices_CellContentClick;
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
            btnSearch.Location = new Point(462, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 48);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmUpdateServiceInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(grpUpdate);
            Controls.Add(btnExit);
            Controls.Add(grpServices);
            Name = "frmUpdateServiceInformation";
            Text = "Dentist Clinic System - [Update Service Information]";
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpServices;
        private Button btnUpdate;
        private TextBox txtServiceTitle;
        private Label label2;
        private Label label1;
        private Button btnExit;
        private TextBox txtPrice;
        private GroupBox grpUpdate;
        private DataGridView grdServices;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}