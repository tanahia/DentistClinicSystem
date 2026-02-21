namespace DentistClinicSystem
{
    partial class frmUpdateDentistInformation
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
            grpUpdate = new GroupBox();
            cmbUpdateDentist = new ComboBox();
            btnUpdate = new Button();
            txtBio = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtDentistFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFullName = new Label();
            btnExit = new Button();
            grpUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // grpUpdate
            // 
            grpUpdate.Controls.Add(cmbUpdateDentist);
            grpUpdate.Controls.Add(btnUpdate);
            grpUpdate.Controls.Add(txtBio);
            grpUpdate.Controls.Add(txtAddress);
            grpUpdate.Controls.Add(txtPhone);
            grpUpdate.Controls.Add(txtDentistFullName);
            grpUpdate.Controls.Add(label3);
            grpUpdate.Controls.Add(label2);
            grpUpdate.Controls.Add(label1);
            grpUpdate.Controls.Add(lblFullName);
            grpUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpUpdate.ForeColor = SystemColors.HotTrack;
            grpUpdate.Location = new Point(26, 33);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(747, 519);
            grpUpdate.TabIndex = 0;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Choose dentist to update:";
            // 
            // cmbUpdateDentist
            // 
            cmbUpdateDentist.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateDentist.FormattingEnabled = true;
            cmbUpdateDentist.Items.AddRange(new object[] { "001" });
            cmbUpdateDentist.Location = new Point(13, 53);
            cmbUpdateDentist.Name = "cmbUpdateDentist";
            cmbUpdateDentist.Size = new Size(192, 31);
            cmbUpdateDentist.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.HotTrack;
            btnUpdate.Location = new Point(160, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 56);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(160, 294);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(196, 96);
            txtBio.TabIndex = 4;
            txtBio.Text = "Bio";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(160, 245);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(192, 30);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "Street2";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(160, 188);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 30);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "+353";
            // 
            // txtDentistFullName
            // 
            txtDentistFullName.Location = new Point(160, 147);
            txtDentistFullName.Name = "txtDentistFullName";
            txtDentistFullName.Size = new Size(125, 30);
            txtDentistFullName.TabIndex = 1;
            txtDentistFullName.Text = "Mary Jane";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 294);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 11;
            label3.Text = "Bio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 245);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 9;
            label2.Text = "Home Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 195);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 7;
            label1.Text = "Phone Number:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(13, 147);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(107, 23);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Full Name: ";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(701, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmUpdateDentistInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(btnExit);
            Controls.Add(grpUpdate);
            Name = "frmUpdateDentistInformation";
            Text = "Dentist Clinic System - [Update Dentist Information]";
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUpdate;
        private TextBox txtBio;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtDentistFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblFullName;
        private Button btnUpdate;
        private Button btnExit;
        private ComboBox cmbUpdateDentist;
    }
}