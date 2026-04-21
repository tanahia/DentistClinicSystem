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
            if (grdServices.CurrentCell == null)
            {
                MessageBox.Show("Please select a dentist from the list.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("If you proceed with operation all records connected to this service will be removed in database. Do you want to continue?",
                             "Confirmation",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Service service = Service.GetServiceByID(Convert.ToInt32(grdServices.Rows[grdServices.CurrentCell.RowIndex].Cells[0].Value));
                    service.RemoveService();

                    grdServices.Visible = false;
                    txtSearch.Clear();
                    txtSearch.Focus();
                    MessageBox.Show("Service removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Service Title must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            else if (int.TryParse(txtSearch.Text, out i))
            {
                MessageBox.Show("Service Title must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            grdServices.DataSource = Service.FindServices(txtSearch.Text).Tables[0];

            if (grdServices.Rows.Count == 0)
            {

                MessageBox.Show("No Data Found");

                txtSearch.Focus();

                return;


            }
            grdServices.Visible = true;
        }

        private void grdServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdServices.Rows[grdServices.CurrentCell.RowIndex].Cells[0].Value);
            Service service = Service.GetServiceByID(ID);
        }
    }
}
