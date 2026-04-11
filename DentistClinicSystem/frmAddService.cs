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
            if (cmbDentistName.Text == "")
               {
                   MessageBox.Show("Please select a DentistID to add service.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   cmbDentistName.Focus();
                   return;
               }
             else  if (txtServiceTitle.Text.Equals(""))
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

            Service service = new Service(Convert.ToInt32(txtServiceID.Text), txtServiceTitle.Text, Convert.ToDecimal(txtPrice.Text), cmbDentistName.Text.Substring(0, 2));
            service.AddService();
            MessageBox.Show("Service added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtServiceID.Text = Service.GetNextServiceID().ToString("00");
            cmbDentistName.Items.Clear();
            txtPrice.Clear();
            txtServiceTitle.Clear();
            txtServiceTitle.Focus();
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            txtServiceID.Text = Service.GetNextServiceID().ToString("00");


            DataSet ds = Dentist.getDentists();


            cmbDentistName.Items.Clear();


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

            {

                cmbDentistName.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);

            }
        }
    }
}
