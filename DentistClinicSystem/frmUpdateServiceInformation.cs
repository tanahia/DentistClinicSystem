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
    public partial class frmUpdateServiceInformation : Form
    {
        frmMainMenu parent;
        public frmUpdateServiceInformation()
        {
            InitializeComponent();
        }
        public frmUpdateServiceInformation(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i;
            if (cmbServiceUpdate.Text == "")
            {
                MessageBox.Show("Please select a ServiceID to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbServiceUpdate.Focus();
                return;
            }

            else if (cmbDentistID.Text == "")
            {
                MessageBox.Show("Please select a ServiceID to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbDentistID.Focus();
                return;
            }
        
            else if (txtServiceTitle.Text.Equals(""))
            {
                MessageBox.Show("Service Title must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceTitle.Focus();
                return;
            }
            else if (int.TryParse(txtServiceTitle.Text, out i))
            {
                MessageBox.Show("Service Title must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceTitle.Focus();
                return;
            }
            else if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Price must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            else if (!(int.TryParse(txtPrice.Text, out i)))
            {
                MessageBox.Show("Price must be numeric.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            
            
            
            MessageBox.Show("Service  is updated in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbDentistID.Items.Clear();
            txtPrice.Clear();
            txtServiceTitle.Clear();
            cmbServiceUpdate.Items.Clear();
            cmbDentistID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

    }
}
