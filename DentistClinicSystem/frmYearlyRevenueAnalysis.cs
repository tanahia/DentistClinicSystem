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
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMainMenu parent;
        
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cmbYear.Text == "")
            {
                MessageBox.Show("Please select a year to display report.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYear.Focus();
                return;
            }
            

                cmbYear.Items.Clear();
            cmbYear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
