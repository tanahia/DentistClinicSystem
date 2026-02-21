namespace DentistClinicSystem
{
    partial class frmAddDentist
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
            btnSave = new Button();
            txtBio = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            btnExit = new Button();
            txtDentistID = new TextBox();
            label4 = new Label();
            grpAddDentist.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddDentist
            // 
            grpAddDentist.Controls.Add(btnSave);
            grpAddDentist.Controls.Add(txtBio);
            grpAddDentist.Controls.Add(txtAddress);
            grpAddDentist.Controls.Add(txtPhone);
            grpAddDentist.Controls.Add(txtFullName);
            grpAddDentist.Controls.Add(label3);
            grpAddDentist.Controls.Add(label2);
            grpAddDentist.Controls.Add(label1);
            grpAddDentist.Controls.Add(lblFullName);
            grpAddDentist.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddDentist.ForeColor = SystemColors.HotTrack;
            grpAddDentist.Location = new Point(26, 93);
            grpAddDentist.Name = "grpAddDentist";
            grpAddDentist.RightToLeft = RightToLeft.No;
            grpAddDentist.Size = new Size(747, 459);
            grpAddDentist.TabIndex = 0;
            grpAddDentist.TabStop = false;
            grpAddDentist.Text = "Enter the Details:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HotTrack;
            btnSave.Location = new Point(164, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 56);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(168, 190);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(196, 96);
            txtBio.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(168, 141);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(192, 30);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 84);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(168, 43);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 30);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 190);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 3;
            label3.Text = "Bio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 141);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Home Address:";
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
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(21, 43);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name: ";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(701, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtDentistID
            // 
            txtDentistID.Location = new Point(194, 33);
            txtDentistID.Name = "txtDentistID";
            txtDentistID.Size = new Size(125, 27);
            txtDentistID.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(47, 33);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 9;
            label4.Text = "Dentist ID: ";
            // 
            // frmAddDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(label4);
            Controls.Add(txtDentistID);
            Controls.Add(btnExit);
            Controls.Add(grpAddDentist);
            Name = "frmAddDentist";
            Text = "Dentist Clinic System - [Add Dentist]";
            grpAddDentist.ResumeLayout(false);
            grpAddDentist.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAddDentist;
        private Label label2;
        private Label label1;
        private Label lblFullName;
        private Button btnSave;
        private TextBox txtBio;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label3;
        private Button btnExit;
        private TextBox txtDentistID;
        private Label label4;
    }
}