namespace DentistClinicSystem
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            logoMain = new PictureBox();
            nmuDentists = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            addDentistToolStripMenuItem = new ToolStripMenuItem();
            updateDentistInformationToolStripMenuItem = new ToolStripMenuItem();
            removeDentistToolStripMenuItem = new ToolStripMenuItem();
            nmuPatients = new ToolStripMenuItem();
            addPatientToolStripMenuItem = new ToolStripMenuItem();
            updatePatientInformationToolStripMenuItem = new ToolStripMenuItem();
            removePatientToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            addServiceToolStripMenuItem = new ToolStripMenuItem();
            updateServiceInformationToolStripMenuItem = new ToolStripMenuItem();
            removeServiceToolStripMenuItem = new ToolStripMenuItem();
            appointmentsToolStripMenuItem = new ToolStripMenuItem();
            makeAppointmentToolStripMenuItem = new ToolStripMenuItem();
            rescheduleAppointmentToolStripMenuItem = new ToolStripMenuItem();
            cancelAppointmentToolStripMenuItem = new ToolStripMenuItem();
            makePrescriptionToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            yearlyRevenueAnalysisToolStripMenuItem = new ToolStripMenuItem();
            frmWelcome = new Label();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)logoMain).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // logoMain
            // 
            logoMain.Image = Properties.Resources._20944856;
            logoMain.Location = new Point(734, 0);
            logoMain.Name = "logoMain";
            logoMain.Size = new Size(85, 68);
            logoMain.SizeMode = PictureBoxSizeMode.StretchImage;
            logoMain.TabIndex = 0;
            logoMain.TabStop = false;
            // 
            // nmuDentists
            // 
            nmuDentists.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator6, addDentistToolStripMenuItem, updateDentistInformationToolStripMenuItem, removeDentistToolStripMenuItem });
            nmuDentists.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmuDentists.ForeColor = Color.CornflowerBlue;
            nmuDentists.Name = "nmuDentists";
            nmuDentists.Padding = new Padding(5, 20, 10, 0);
            nmuDentists.Size = new Size(129, 63);
            nmuDentists.Text = "Dentists";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(326, 6);
            // 
            // addDentistToolStripMenuItem
            // 
            addDentistToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDentistToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            addDentistToolStripMenuItem.Name = "addDentistToolStripMenuItem";
            addDentistToolStripMenuItem.Size = new Size(329, 28);
            addDentistToolStripMenuItem.Text = "Add Dentist";
            addDentistToolStripMenuItem.Click += addDentistToolStripMenuItem_Click;
            // 
            // updateDentistInformationToolStripMenuItem
            // 
            updateDentistInformationToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateDentistInformationToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            updateDentistInformationToolStripMenuItem.Name = "updateDentistInformationToolStripMenuItem";
            updateDentistInformationToolStripMenuItem.Size = new Size(329, 28);
            updateDentistInformationToolStripMenuItem.Text = "Update Dentist Information";
            updateDentistInformationToolStripMenuItem.Click += updateDentistInformationToolStripMenuItem_Click;
            // 
            // removeDentistToolStripMenuItem
            // 
            removeDentistToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeDentistToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            removeDentistToolStripMenuItem.Name = "removeDentistToolStripMenuItem";
            removeDentistToolStripMenuItem.Size = new Size(329, 28);
            removeDentistToolStripMenuItem.Text = "Remove Dentist";
            removeDentistToolStripMenuItem.Click += removeDentistToolStripMenuItem_Click;
            // 
            // nmuPatients
            // 
            nmuPatients.DropDownItems.AddRange(new ToolStripItem[] { addPatientToolStripMenuItem, updatePatientInformationToolStripMenuItem, removePatientToolStripMenuItem });
            nmuPatients.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmuPatients.ForeColor = Color.CornflowerBlue;
            nmuPatients.Name = "nmuPatients";
            nmuPatients.Padding = new Padding(5, 0, 10, 0);
            nmuPatients.Size = new Size(130, 63);
            nmuPatients.Text = "Patients";
            // 
            // addPatientToolStripMenuItem
            // 
            addPatientToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPatientToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            addPatientToolStripMenuItem.Size = new Size(329, 28);
            addPatientToolStripMenuItem.Text = "Add Patient";
            addPatientToolStripMenuItem.Click += addPatientToolStripMenuItem_Click;
            // 
            // updatePatientInformationToolStripMenuItem
            // 
            updatePatientInformationToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatePatientInformationToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            updatePatientInformationToolStripMenuItem.Name = "updatePatientInformationToolStripMenuItem";
            updatePatientInformationToolStripMenuItem.Size = new Size(329, 28);
            updatePatientInformationToolStripMenuItem.Text = "Update Patient Information";
            updatePatientInformationToolStripMenuItem.Click += updatePatientInformationToolStripMenuItem_Click;
            // 
            // removePatientToolStripMenuItem
            // 
            removePatientToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removePatientToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            removePatientToolStripMenuItem.Name = "removePatientToolStripMenuItem";
            removePatientToolStripMenuItem.Size = new Size(329, 28);
            removePatientToolStripMenuItem.Text = "Remove Patient";
            removePatientToolStripMenuItem.Click += removePatientToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.AllowMerge = false;
            menuStrip1.BackColor = Color.Lavender;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nmuDentists, nmuPatients, servicesToolStripMenuItem, appointmentsToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MaximumSize = new Size(930, 67);
            menuStrip1.MinimumSize = new Size(930, 67);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new Size(930, 67);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addServiceToolStripMenuItem, updateServiceInformationToolStripMenuItem, removeServiceToolStripMenuItem });
            servicesToolStripMenuItem.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            servicesToolStripMenuItem.ForeColor = Color.CornflowerBlue;
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Padding = new Padding(5, 0, 10, 0);
            servicesToolStripMenuItem.Size = new Size(130, 63);
            servicesToolStripMenuItem.Text = "Services";
            // 
            // addServiceToolStripMenuItem
            // 
            addServiceToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addServiceToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            addServiceToolStripMenuItem.Size = new Size(331, 28);
            addServiceToolStripMenuItem.Text = "Add Service";
            addServiceToolStripMenuItem.Click += addServiceToolStripMenuItem_Click;
            // 
            // updateServiceInformationToolStripMenuItem
            // 
            updateServiceInformationToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateServiceInformationToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            updateServiceInformationToolStripMenuItem.Name = "updateServiceInformationToolStripMenuItem";
            updateServiceInformationToolStripMenuItem.Size = new Size(331, 28);
            updateServiceInformationToolStripMenuItem.Text = "Update Service Information";
            updateServiceInformationToolStripMenuItem.Click += updateServiceInformationToolStripMenuItem_Click;
            // 
            // removeServiceToolStripMenuItem
            // 
            removeServiceToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeServiceToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            removeServiceToolStripMenuItem.Name = "removeServiceToolStripMenuItem";
            removeServiceToolStripMenuItem.Size = new Size(331, 28);
            removeServiceToolStripMenuItem.Text = "Remove Service";
            removeServiceToolStripMenuItem.Click += removeServiceToolStripMenuItem_Click;
            // 
            // appointmentsToolStripMenuItem
            // 
            appointmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { makeAppointmentToolStripMenuItem, rescheduleAppointmentToolStripMenuItem, cancelAppointmentToolStripMenuItem, makePrescriptionToolStripMenuItem });
            appointmentsToolStripMenuItem.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentsToolStripMenuItem.ForeColor = Color.CornflowerBlue;
            appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            appointmentsToolStripMenuItem.Padding = new Padding(5, 0, 10, 0);
            appointmentsToolStripMenuItem.Size = new Size(202, 63);
            appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // makeAppointmentToolStripMenuItem
            // 
            makeAppointmentToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeAppointmentToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            makeAppointmentToolStripMenuItem.Name = "makeAppointmentToolStripMenuItem";
            makeAppointmentToolStripMenuItem.Size = new Size(306, 28);
            makeAppointmentToolStripMenuItem.Text = "Make Appointment";
            makeAppointmentToolStripMenuItem.Click += makeAppointmentToolStripMenuItem_Click;
            // 
            // rescheduleAppointmentToolStripMenuItem
            // 
            rescheduleAppointmentToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rescheduleAppointmentToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            rescheduleAppointmentToolStripMenuItem.Name = "rescheduleAppointmentToolStripMenuItem";
            rescheduleAppointmentToolStripMenuItem.Size = new Size(306, 28);
            rescheduleAppointmentToolStripMenuItem.Text = "Reschedule Appointment";
            rescheduleAppointmentToolStripMenuItem.Click += rescheduleAppointmentToolStripMenuItem_Click;
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            cancelAppointmentToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelAppointmentToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            cancelAppointmentToolStripMenuItem.Size = new Size(306, 28);
            cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            cancelAppointmentToolStripMenuItem.Click += cancelAppointmentToolStripMenuItem_Click;
            // 
            // makePrescriptionToolStripMenuItem
            // 
            makePrescriptionToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makePrescriptionToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            makePrescriptionToolStripMenuItem.Name = "makePrescriptionToolStripMenuItem";
            makePrescriptionToolStripMenuItem.Size = new Size(306, 28);
            makePrescriptionToolStripMenuItem.Text = "Make Prescription";
            makePrescriptionToolStripMenuItem.Click += makePrescriptionToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.BackColor = Color.Lavender;
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yearlyRevenueAnalysisToolStripMenuItem });
            adminToolStripMenuItem.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminToolStripMenuItem.ForeColor = Color.CornflowerBlue;
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Padding = new Padding(5, 0, 10, 0);
            adminToolStripMenuItem.Size = new Size(115, 63);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            yearlyRevenueAnalysisToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearlyRevenueAnalysisToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            yearlyRevenueAnalysisToolStripMenuItem.Size = new Size(299, 28);
            yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly revenue Analysis";
            yearlyRevenueAnalysisToolStripMenuItem.Click += yearlyRevenueAnalysisToolStripMenuItem_Click;
            // 
            // frmWelcome
            // 
            frmWelcome.AutoSize = true;
            frmWelcome.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmWelcome.ForeColor = Color.DodgerBlue;
            frmWelcome.Location = new Point(210, 125);
            frmWelcome.Name = "frmWelcome";
            frmWelcome.Size = new Size(519, 33);
            frmWelcome.TabIndex = 2;
            frmWelcome.Text = "Welcome to Dentist Clinic System!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(126, 188);
            label1.Name = "label1";
            label1.Size = new Size(724, 88);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.CornflowerBlue;
            btnExit.Location = new Point(843, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(928, 508);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(frmWelcome);
            Controls.Add(logoMain);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmMainMenu";
            Padding = new Padding(0, 0, 10, 0);
            Text = "Dentist Clinic System - [Main Menu]";
            Load += frmMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)logoMain).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoMain;
        private ToolStripMenuItem nmuDentists;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem nmuPatients;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem appointmentsToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private Label frmWelcome;
        private Label label1;
        private ToolStripMenuItem addDentistToolStripMenuItem;
        private ToolStripMenuItem updateDentistInformationToolStripMenuItem;
        private ToolStripMenuItem removeDentistToolStripMenuItem;
        private ToolStripMenuItem addPatientToolStripMenuItem;
        private ToolStripMenuItem updatePatientInformationToolStripMenuItem;
        private ToolStripMenuItem removePatientToolStripMenuItem;
        private ToolStripMenuItem addServiceToolStripMenuItem;
        private ToolStripMenuItem updateServiceInformationToolStripMenuItem;
        private ToolStripMenuItem removeServiceToolStripMenuItem;
        private ToolStripMenuItem makeAppointmentToolStripMenuItem;
        private ToolStripMenuItem rescheduleAppointmentToolStripMenuItem;
        private ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private ToolStripMenuItem makePrescriptionToolStripMenuItem;
        private ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private Button btnExit;
    }
}
