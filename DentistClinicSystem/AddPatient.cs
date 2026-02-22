using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmAddPatient : Form
    {
        frmMainMenu parent;
        public frmAddPatient()
        {
            InitializeComponent();
        }
        public frmAddPatient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                MessageBox.Show("Phone number must start with '+' and have only numeric characters expect the first character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (dtpDateofBirth.Value >= DateTime.Today)
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

            MessageBox.Show("Patient added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtDentalProblems.Clear();
            txtHealthProblems.Clear();
            txtAllergies.Clear();
            dtpDateofBirth.Value = DateTime.Now; // Resetting the DateTimePicker to the current date
            txtFullName.Focus();

        }


    }
}
