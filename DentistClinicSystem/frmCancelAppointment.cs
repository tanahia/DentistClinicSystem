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
    public partial class frmCancelAppointment : Form
    {
        frmMainMenu parent;
        public frmCancelAppointment()
        {
            InitializeComponent();
        }
        public frmCancelAppointment(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cmbCancelAppointment.Text == "")
            {
                MessageBox.Show("Please select a AppointmentID to cancel appointment.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                cmbCancelAppointment.Focus();
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are You Sure?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Appointment Cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCancelAppointment.Items.Clear();
                cmbCancelAppointment.Focus();
            }

        }


    }
}
