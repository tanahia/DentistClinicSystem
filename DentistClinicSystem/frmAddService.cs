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
    public partial class frmAddService : Form
    {
        frmMainMenu parent;
        public frmAddService()
        {
            InitializeComponent();
        }
        public frmAddService(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            Service service = new Service(Convert.ToInt32(txtServiceID.Text), txtServiceTitle.Text, Convert.ToDecimal(txtPrice.Text));
            service.AddService();
            MessageBox.Show("Service added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtServiceID.Text = Service.GetNextServiceID().ToString("00");
            txtPrice.Clear();
            txtServiceTitle.Clear();
            txtServiceTitle.Focus();
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            txtServiceID.Text = Service.GetNextServiceID().ToString("00");

        }
    }
}
