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
//using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmMakePrescription : Form
    {
        frmMainMenu parent;
        public frmMakePrescription()
        {
            InitializeComponent();
        }
        public frmMakePrescription(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            int i;
            if (txtMedicine.Text.Equals(""))
            {
                MessageBox.Show("Medicine Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedicine.Focus();
                return;
            }
            else if (int.TryParse(txtMedicine.Text, out i))
            {
                MessageBox.Show("Medicine Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMedicine.Focus();
                return;
            }
            else if (txtFullName.Text.Equals(""))
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
            else if (!int.TryParse(txtPhone.Text, out i) || !txtPhone.Text.StartsWith("+"))
            {
                MessageBox.Show("Phone number must start with '+' and have only numeric characters expect the first character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtDentistFullName.Text.Equals(""))
            {
                MessageBox.Show("Dentist Full Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistFullName.Focus();
                return;
            }
            else if (int.TryParse(txtDentistFullName.Text, out i))
            {
                MessageBox.Show("Dentist Full Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistFullName.Focus();
                return;
            }
            else if (txtPharmacyAddress.Text.Equals(""))
            {
                MessageBox.Show("Pharmacy Address must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPharmacyAddress.Focus();
                return;
            }
            else if (txtInstuctions.Text.Equals(""))
            {
                MessageBox.Show("Instructions must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInstuctions.Focus();
                return;
            }
           
            MessageBox.Show("Prescription added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFullName.Clear();
            txtMedicine.Clear();
            txtDentistFullName.Clear();
            txtPhone.Clear();
            txtPharmacyAddress.Clear();
            txtInstuctions.Clear();
            txtMedicine.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
