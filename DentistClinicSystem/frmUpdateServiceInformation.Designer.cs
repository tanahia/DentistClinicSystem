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
            grpUpdateServiceInformation = new GroupBox();
            label3 = new Label();
            cmbDentistID = new ComboBox();
            txtPrice = new TextBox();
            cmbServiceUpdate = new ComboBox();
            btnUpdate = new Button();
            txtServiceTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            grpUpdateServiceInformation.SuspendLayout();
            SuspendLayout();
            // 
            // grpUpdateServiceInformation
            // 
            grpUpdateServiceInformation.Controls.Add(label3);
            grpUpdateServiceInformation.Controls.Add(cmbDentistID);
            grpUpdateServiceInformation.Controls.Add(txtPrice);
            grpUpdateServiceInformation.Controls.Add(cmbServiceUpdate);
            grpUpdateServiceInformation.Controls.Add(btnUpdate);
            grpUpdateServiceInformation.Controls.Add(txtServiceTitle);
            grpUpdateServiceInformation.Controls.Add(label2);
            grpUpdateServiceInformation.Controls.Add(label1);
            grpUpdateServiceInformation.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdateServiceInformation.ForeColor = SystemColors.HotTrack;
            grpUpdateServiceInformation.Location = new Point(27, 40);
            grpUpdateServiceInformation.Name = "grpUpdateServiceInformation";
            grpUpdateServiceInformation.RightToLeft = RightToLeft.No;
            grpUpdateServiceInformation.Size = new Size(747, 450);
            grpUpdateServiceInformation.TabIndex = 3;
            grpUpdateServiceInformation.TabStop = false;
            grpUpdateServiceInformation.Text = "Choose service to update:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 114);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 22;
            label3.Text = "Dentist ID:";

            // 
            // cmbDentistID
            // 
            cmbDentistID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDentistID.FormattingEnabled = true;
            cmbDentistID.Items.AddRange(new object[] { "001" });
            cmbDentistID.Location = new Point(203, 106);
            cmbDentistID.Name = "cmbDentistID";
            cmbDentistID.Size = new Size(192, 31);
            cmbDentistID.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(199, 217);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(53, 30);
            txtPrice.TabIndex = 20;
            txtPrice.Text = "50";
            // 
            // cmbServiceUpdate
            // 
            cmbServiceUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServiceUpdate.FormattingEnabled = true;
            cmbServiceUpdate.Items.AddRange(new object[] { "001" });
            cmbServiceUpdate.Location = new Point(20, 49);
            cmbServiceUpdate.Name = "cmbServiceUpdate";
            cmbServiceUpdate.Size = new Size(192, 31);
            cmbServiceUpdate.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Location = new Point(199, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 56);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtServiceTitle
            // 
            txtServiceTitle.Location = new Point(199, 167);
            txtServiceTitle.Name = "txtServiceTitle";
            txtServiceTitle.Size = new Size(141, 30);
            txtServiceTitle.TabIndex = 2;
            txtServiceTitle.Text = "Teeth Removal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 217);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 167);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 1;
            label1.Text = "Service Title:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(702, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmUpdateServiceInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(btnExit);
            Controls.Add(grpUpdateServiceInformation);
            Name = "frmUpdateServiceInformation";
            Text = "Dentist Clinic System - [Update Service Information]";
            grpUpdateServiceInformation.ResumeLayout(false);
            grpUpdateServiceInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUpdateServiceInformation;
        private ComboBox cmbServiceUpdate;
        private Button btnUpdate;
        private TextBox txtServiceTitle;
        private Label label2;
        private Label label1;
        private Button btnExit;
        private TextBox txtPrice;
        private Label label3;
        private ComboBox cmbDentistID;
    }
}