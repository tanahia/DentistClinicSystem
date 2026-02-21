namespace DentistClinicSystem
{
    partial class frmRemoveDentist
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
            btnRemove = new Button();
            cmbRemoveDentist = new ComboBox();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(cmbRemoveDentist);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(26, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose dentist to remove:";
            // 
            // btnRemove
            // 
            btnRemove.ForeColor = SystemColors.HotTrack;
            btnRemove.Location = new Point(26, 162);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(187, 59);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cmbRemoveDentist
            // 
            cmbRemoveDentist.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRemoveDentist.FormattingEnabled = true;
            cmbRemoveDentist.Items.AddRange(new object[] { "001" });
            cmbRemoveDentist.Location = new Point(21, 62);
            cmbRemoveDentist.Name = "cmbRemoveDentist";
            cmbRemoveDentist.Size = new Size(192, 33);
            cmbRemoveDentist.TabIndex = 0;
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
            // frmRemoveDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "frmRemoveDentist";
            Text = "Dentist Clinic System - [Remove Dentist]";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbRemoveDentist;
        private Button btnRemove;
        private Button btnExit;
    }
}