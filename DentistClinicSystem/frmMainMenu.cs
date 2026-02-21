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
    }
}
