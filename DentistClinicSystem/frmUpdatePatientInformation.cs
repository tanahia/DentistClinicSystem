using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmUpdatePatientInformation : Form
    {
        frmMainMenu parent;
        public frmUpdatePatientInformation()
        {
            InitializeComponent();
        }
        public frmUpdatePatientInformation(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i;
             if (txtFullName.Text.Equals(""))
            {
                MessageBox.Show("Full Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }
            else if (int.TryParse(txtFullName.Text, out i))
            {
                MessageBox.Show("Full Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }
            else if (txtPhone.Text.Equals(""))
            {

                MessageBox.Show("Phone number must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (!int.TryParse(txtPhone.Text, out i))
            {
                MessageBox.Show("Phone number must have only numeric characters expect the first character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Home address must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            else if (dtpDateofBirth.Value.Equals(DateTime.Today))
            {
                MessageBox.Show("Date of Birth must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateofBirth.Focus();
                return;
            }
            else if (dtpDateofBirth.Value > DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be a past date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateofBirth.Focus();
                return;
            }         
            else if (txtDentalProblems.Text.Equals(""))
            {
                MessageBox.Show("Dental problems must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentalProblems.Focus();
                return;
            }
            Patient patient = Patient.GetPatientByID(Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value));
            patient.FullName = txtFullName.Text;
            patient.Phone = txtPhone.Text;
            patient.Address = txtAddress.Text;
            patient.DateOfBirth= dtpDateofBirth.Value;
            patient.DentalProblems= txtDentalProblems.Text;
            patient.HealthProblems= txtHealthProblems.Text;
            patient.Allergies= txtAllergies.Text;

            patient.UpdatePatient();

            MessageBox.Show("Patient is updated in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtDentalProblems.Clear();
            txtHealthProblems.Clear();
            txtAllergies.Clear();
            dtpDateofBirth.Value = DateTime.Now; // Resetting the DateTimePicker to the current date
            grdPatients.Visible = false;
            grpPatients.Visible = false;
            txtFullName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Dentist Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            else if (int.TryParse(txtSearch.Text, out i))
            {
                MessageBox.Show("Full Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            grdPatients.DataSource = Patient.FindPatients(txtSearch.Text).Tables[0];

            if (grdPatients.Rows.Count == 0)
            {

                MessageBox.Show("No Data Found");

                txtSearch.Focus();

                return;

            }
            grdPatients.Visible = true;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value);
            Patient patient = Patient.GetPatientByID(ID);
            txtFullName.Text = patient.FullName;
            txtPhone.Text = patient.Phone;
            txtAddress.Text = patient.Address;
            dtpDateofBirth.Value = patient.DateOfBirth;
            txtDentalProblems.Text = patient.DentalProblems;
            txtHealthProblems.Text = patient.HealthProblems;
            txtAllergies.Text = patient.Allergies;
            grpPatients.Visible = true;
        }
    }
}
