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
    public partial class frmUpdateDentistInformation : Form
    {
        frmMainMenu parent;
        public frmUpdateDentistInformation()
        {
            InitializeComponent();
        }

        public frmUpdateDentistInformation(frmMainMenu parent)
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
            if (cmbUpdateDentist.Text == "")
            {
                MessageBox.Show("Please select a DentistID to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUpdateDentist.Focus();
                return;
            }

            else if (txtDentistFullName.Text.Equals(""))
            {
                MessageBox.Show("Full Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistFullName.Focus();
                return;
            }
            else if (int.TryParse(txtDentistFullName.Text, out i))
            {
                MessageBox.Show("Full Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistFullName.Focus();
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
            else if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Home address must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
            else if (txtBio.Text.Equals(""))
            {
                MessageBox.Show("Bio must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBio.Focus();
                return;
            }
           
            MessageBox.Show("Dentist Information is updated in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDentistFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtBio.Clear();
            cmbUpdateDentist.Items.Clear();
            txtDentistFullName.Focus();
        }
    }
}
