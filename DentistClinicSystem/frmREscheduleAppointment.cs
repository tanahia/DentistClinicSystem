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
//using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmRescheduleAppointment : Form
    {
        frmMainMenu parent;
        public frmRescheduleAppointment()
        {
            InitializeComponent();
        }
        public frmRescheduleAppointment(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnReschedule_Click(object sender, EventArgs e)
        {
            if (cmbRescheduleAppointment.Text == "")
            {
                MessageBox.Show("Please select a AppointmentID to reschedule appointment.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbRescheduleAppointment.Focus();
                return;
            }
            else if (dtpAppointmentDate.Value.Equals(DateTime.Today))
            {
                MessageBox.Show("Appointment Date must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAppointmentDate.Focus();
                return;
            }
            else if (dtpAppointmentDate.Value >= DateTime.Today)
            {
                MessageBox.Show("Appointment Date must be a past date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAppointmentDate.Focus();
                return;
            }
           
            MessageBox.Show("Apointment rescheduled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpAppointmentDate.Value = DateTime.Now;
            cmbRescheduleAppointment.Items.Clear();
            cmbRescheduleAppointment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cmbRescheduleAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
