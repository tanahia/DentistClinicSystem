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
    public partial class frmRemovePatient : Form
    {
        frmMainMenu parent;
        public frmRemovePatient()
        {
            InitializeComponent();
        }
        public frmRemovePatient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbRemovePatient.Text == "")
            {
                MessageBox.Show("Please select a PatientID to remove.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRemovePatient.Focus();
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are You Sure?",
                         "Confirmation",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Patient removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbRemovePatient.Items.Clear();
                cmbRemovePatient.Focus();
            }

        }
    }
}
