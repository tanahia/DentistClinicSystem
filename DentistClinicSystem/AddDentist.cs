using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmAddDentist : Form
    {
        frmMainMenu parent;

        public frmAddDentist()
        {
            InitializeComponent();
        }

        public frmAddDentist(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
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
                MessageBox.Show("Phone number must  have only numeric characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtBio.Clear();
            txtFullName.Focus();


        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }


 
    }
}
