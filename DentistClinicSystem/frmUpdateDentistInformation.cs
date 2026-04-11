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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i;
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("DEntist Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

           
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void grdDentists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdDentists.Rows[grdDentists.CurrentCell.RowIndex].Cells[0].Value);
            Dentist dentist = Dentist.GetDentistByID(ID);
            txtFullName.Text = dentist.FullName;
            txtPhone.Text = dentist.Phone;
            txtAddress.Text = dentist.Address;
            txtBio.Text = dentist.Bio;
            grpDentists.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            Dentist dentist = Dentist.GetDentistByID(Convert.ToInt32(grdDentists.Rows[grdDentists.CurrentCell.RowIndex].Cells[0].Value));
            dentist.FullName= txtFullName.Text;
            dentist.Phone= txtPhone.Text;
            dentist.Address= txtAddress.Text;
            dentist.Bio= txtBio.Text;

            dentist.UpdateDentist();
            MessageBox.Show("Dentist Information is updated in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFullName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtBio.Clear();
                grdDentists.Visible = false;
                grpDentists.Visible = false;
                txtSearch.Focus();
        }
    }
}
