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
    public partial class frmRemoveDentist : Form
    {
        frmMainMenu parent;
        public frmRemoveDentist()
        {
            InitializeComponent();
        }

        public frmRemoveDentist(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbRemoveDentist.Text == "")
            {
                MessageBox.Show("Please select a DentistID to remove.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRemoveDentist.Focus();
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are You Sure?",
                          "Confirmation",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Dentist removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbRemoveDentist.Items.Clear();
                cmbRemoveDentist.Focus();
            }
            
        }
    }
}
