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
    }
}
