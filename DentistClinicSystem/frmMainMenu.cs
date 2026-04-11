namespace DentistClinicSystem
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?",
                           "Confirmation",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addDentistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDentist frmAddDentist = new frmAddDentist(this);
            frmAddDentist.Show();

        }

        private void updateDentistInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateDentistInformation frmUpdateDentistInformation = new frmUpdateDentistInformation(this);
            frmUpdateDentistInformation.Show();
        }

        private void removeDentistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveDentist frmRemoveDentist = new frmRemoveDentist(this);
            frmRemoveDentist.Show();

        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPatient frmAddPatient = new frmAddPatient(this);
            frmAddPatient.Show();

        }

        private void removePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemovePatient frmRemovePatient = new frmRemovePatient(this);
            frmRemovePatient.Show();

        }

        private void updatePatientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdatePatientInformation frmUpdatePatientInformation = new frmUpdatePatientInformation(this);
            frmUpdatePatientInformation.Show();
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddService frmAddService = new frmAddService(this);
            frmAddService.Show();
        }

        private void updateServiceInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateServiceInformation frmUpdateServiceInformation = new frmUpdateServiceInformation(this);
            frmUpdateServiceInformation.Show();
        }

        private void removeServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveService frmRemoveService = new frmRemoveService(this);
            frmRemoveService.Show();

        }

        private void makeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeAppointment frmMakeAppointment = new frmMakeAppointment(this);
            frmMakeAppointment.Show();

        }

        private void rescheduleAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRescheduleAppointment frmRescheduleAppointment = new frmRescheduleAppointment(this);
            frmRescheduleAppointment.Show();
        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelAppointment frmCancelAppointment = new frmCancelAppointment(this);
            frmCancelAppointment.Show();

        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysis frmYearlyRevenueAnalysis = new frmYearlyRevenueAnalysis(this);
            frmYearlyRevenueAnalysis.Show();

        }

    }
}
