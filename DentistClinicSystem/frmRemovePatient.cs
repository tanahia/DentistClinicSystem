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
            if (grdPatients.CurrentCell == null)
            {
                MessageBox.Show("Please select a dentist from the list.");
                return;
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("If you proceed with operation all records connected to this patient will be removed in database. Do you want to continue?",
                          "Confirmation",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Patient patient = Patient.GetPatientByID(Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value));
                    patient.RemovePatient();

                    grdPatients.Visible = false;
                    txtSearch.Clear();
                    txtSearch.Focus();

                    MessageBox.Show("Patient removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Patient Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            else if (int.TryParse(txtSearch.Text, out i))
            {
                MessageBox.Show("Patient Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void grdPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdPatients.Rows[grdPatients.CurrentCell.RowIndex].Cells[0].Value);
            Patient patient = Patient.GetPatientByID(ID);
        }
    }
}
