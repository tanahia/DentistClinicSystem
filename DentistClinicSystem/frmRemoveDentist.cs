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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Dentist Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            else if (int.TryParse(txtSearch.Text, out i))
            {
                MessageBox.Show("Full Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            grdDentists.DataSource = Dentist.FindDentists(txtSearch.Text).Tables[0];

            if (grdDentists.Rows.Count == 0)
            {

                MessageBox.Show("No Data Found");

                txtSearch.Focus();

                return;


            }
            grdDentists.Visible = true;
        }

        private void grdDentists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdDentists.Rows[grdDentists.CurrentCell.RowIndex].Cells[0].Value);
            Dentist dentist = Dentist.GetDentistByID(ID);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdDentists.CurrentCell == null)
            {
                MessageBox.Show("Please select a dentist from the list.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("If you proceed with operation all records connected to this dentist will be removed in database. Do you want to continue?",
                           "Confirmation",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Dentist dentist = Dentist.GetDentistByID(Convert.ToInt32(grdDentists.Rows[grdDentists.CurrentCell.RowIndex].Cells[0].Value));


                    dentist.RemoveDentist();

                    grdDentists.Visible = false;
                    txtSearch.Clear();
                    txtSearch.Focus();
                    MessageBox.Show("Dentist removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
    }
}
