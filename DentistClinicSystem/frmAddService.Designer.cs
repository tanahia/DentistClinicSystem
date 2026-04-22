namespace DentistClinicSystem
{
    partial class frmAddService
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
            txtServiceID = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            txtPrice = new TextBox();
            txtServiceTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            grpAddDentist.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddDentist
            // 
            grpAddDentist.Controls.Add(txtServiceID);
            grpAddDentist.Controls.Add(label3);
            grpAddDentist.Controls.Add(btnSave);
            grpAddDentist.Controls.Add(txtPrice);
            grpAddDentist.Controls.Add(txtServiceTitle);
            grpAddDentist.Controls.Add(label2);
            grpAddDentist.Controls.Add(label1);
            grpAddDentist.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddDentist.ForeColor = SystemColors.HotTrack;
            grpAddDentist.Location = new Point(27, 81);
            grpAddDentist.Name = "grpAddDentist";
            grpAddDentist.RightToLeft = RightToLeft.No;
            grpAddDentist.Size = new Size(920, 471);
            grpAddDentist.TabIndex = 1;
            grpAddDentist.TabStop = false;
            grpAddDentist.Text = "Enter the Details:";
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new Point(185, 43);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new Size(81, 30);
            txtServiceID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 46);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 11;
            label3.Text = "Service ID:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HotTrack;
            btnSave.Location = new Point(175, 274);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 56);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(185, 138);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(53, 30);
            txtPrice.TabIndex = 3;
            // 
            // txtServiceTitle
            // 
            txtServiceTitle.Location = new Point(185, 87);
            txtServiceTitle.Name = "txtServiceTitle";
            txtServiceTitle.Size = new Size(125, 30);
            txtServiceTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 138);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 90);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 1;
            label1.Text = "Service Title:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(875, 27);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 580);
            Controls.Add(grpAddDentist);
            Controls.Add(btnExit);
            Name = "frmAddService";
            Text = "Dentist Clinic System - [AddService]";
            Load += frmAddService_Load;
            grpAddDentist.ResumeLayout(false);
            grpAddDentist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddDentist;
        private TextBox txtPrice;
        private TextBox txtServiceTitle;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnExit;
        private Label label3;
        private TextBox txtServiceID;
    }
}