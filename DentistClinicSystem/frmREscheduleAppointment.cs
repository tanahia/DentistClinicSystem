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
            if (dtpAppointmentDate.Value.Equals(DateTime.Today))
            {
                MessageBox.Show("Appointment Date must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAppointmentDate.Focus();
                return;
            }
            else if (dtpAppointmentDate.Value < DateTime.Today)
            {
                MessageBox.Show("Appointment Date must be a future date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAppointmentDate.Focus();
                return;
            }
            Appointment appointment = Appointment.GetAppointmentByID(Convert.ToInt32(grdAppointments.Rows[grdAppointments.CurrentCell.RowIndex].Cells[0].Value));
            appointment.AptDate = dtpAppointmentDate.Value;
            appointment.UpdateAppointment();

            MessageBox.Show("Apointment rescheduled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpSearch.Value = DateTime.Today;
            grdAppointments.Visible = false;
            grpRescheduleAppointment.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cmbRescheduleAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpSearch.Value < DateTime.Today)
            {
                MessageBox.Show("Appointment Date must be a today or future date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAppointmentDate.Focus();
                return;
            }
            grdAppointments.DataSource = Appointment.FindAppointments(dtpSearch.Value).Tables[0];
            if (grdAppointments.Rows.Count == 0)
            {

                MessageBox.Show("No Data Found");

                dtpSearch.Focus();

                return;

            }
            grdAppointments.Visible = true;
            dtpSearch.Value = DateTime.Today;
            dtpSearch.Focus();
        }

        private void frmRescheduleAppointment_Load(object sender, EventArgs e)
        {
            dtpSearch.Value = DateTime.Today;
            dtpAppointmentDate.Value = DateTime.Today;
        }

        private void grdAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdAppointments.Rows[grdAppointments.CurrentCell.RowIndex].Cells[0].Value);          
            Appointment appointment = Appointment.GetAppointmentByID(ID);
            dtpAppointmentDate.Value = appointment.AptDate;
            grpRescheduleAppointment.Visible = true;    
        }
    }
}
