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
           if (txtServiceTitle.Text.Equals(""))
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
            Service service= Service.GetServiceByID(Convert.ToInt32(grdServices.Rows[grdServices.CurrentCell.RowIndex].Cells[0].Value));
            service.ServiceTitle = txtServiceTitle.Text;
            service.Price = Convert.ToDecimal(txtPrice.Text);
            service.UpdateService();

            MessageBox.Show("Service  is updated in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPrice.Clear();
            txtServiceTitle.Clear();
            grdServices.Visible = false;
            grpServices.Visible = false;
            txtServiceTitle.Focus();
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        public void btnSearch_Click(object sender, EventArgs e)
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
                MessageBox.Show("Dentist Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void grdServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdServices.Rows[grdServices.CurrentCell.RowIndex].Cells[0].Value);
            Service service=Service.GetServiceByID(ID);
            txtServiceTitle.Text = service.ServiceTitle;
            txtPrice.Text = service.Price.ToString();
           grpServices.Visible = true;
            
        }
    }
}
