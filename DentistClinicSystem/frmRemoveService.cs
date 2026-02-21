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
    public partial class frmRemoveService : Form
    {
        frmMainMenu parent;
        public frmRemoveService()
        {
            InitializeComponent();
        }
        public frmRemoveService(frmMainMenu parent)
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
            if(cmbRemoveService.Text == "")
            {
                MessageBox.Show("Please select a ServiceID to remove.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRemoveService.Focus();
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are You Sure?",
             "Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Service removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbRemoveService.Items.Clear();
                cmbRemoveService.Focus();
            }

        }
    }
}
