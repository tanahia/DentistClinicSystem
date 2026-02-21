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
            label3 = new Label();
            btnExit = new Button();
            btnSave = new Button();
            txtPrice = new TextBox();
            txtServiceTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbDentistID = new ComboBox();
            grpAddDentist.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddDentist
            // 
            grpAddDentist.Controls.Add(label3);
            grpAddDentist.Controls.Add(cmbDentistID);
            grpAddDentist.Controls.Add(btnExit);
            grpAddDentist.Controls.Add(btnSave);
            grpAddDentist.Controls.Add(txtPrice);
            grpAddDentist.Controls.Add(txtServiceTitle);
            grpAddDentist.Controls.Add(label2);
            grpAddDentist.Controls.Add(label1);
            grpAddDentist.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddDentist.ForeColor = SystemColors.HotTrack;
            grpAddDentist.Location = new Point(26, 12);
            grpAddDentist.Name = "grpAddDentist";
            grpAddDentist.RightToLeft = RightToLeft.No;
            grpAddDentist.Size = new Size(747, 400);
            grpAddDentist.TabIndex = 1;
            grpAddDentist.TabStop = false;
            grpAddDentist.Text = "Enter the Details:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 46);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 11;
            label3.Text = "Dentist ID:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(545, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.HotTrack;
            btnSave.Location = new Point(171, 207);
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
            txtServiceTitle.Location = new Point(185, 84);
            txtServiceTitle.Name = "txtServiceTitle";
            txtServiceTitle.Size = new Size(125, 30);
            txtServiceTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 141);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 91);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 1;
            label1.Text = "Service Title:";
            // 
            // cmbDentistID
            // 
            cmbDentistID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDentistID.FormattingEnabled = true;
            cmbDentistID.Items.AddRange(new object[] { "001" });
            cmbDentistID.Location = new Point(185, 38);
            cmbDentistID.Name = "cmbDentistID";
            cmbDentistID.Size = new Size(192, 31);
            cmbDentistID.TabIndex = 10;
            // 
            // frmAddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(grpAddDentist);
            Name = "frmAddService";
            Text = "Dentist Clinic System - [AddService]";
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
        private ComboBox cmbDentistID;
    }
}