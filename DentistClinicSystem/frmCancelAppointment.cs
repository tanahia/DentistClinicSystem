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
            if (grdAppointments.CurrentCell == null)
            {
                MessageBox.Show("Please select a appointment from the list.");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("If you proceed with operation all records connected to this appointment will be removed in database. Do you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Appointment appointment = Appointment.GetAppointmentByID(Convert.ToInt32(grdAppointments.Rows[grdAppointments.CurrentCell.RowIndex].Cells[0].Value));
                    appointment.CancelAppointment();

                    grdAppointments.Visible = false;
                    dtpSearch.Value = DateTime.Today;
                    dtpSearch.Focus();

                    MessageBox.Show("Appointment Cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            if (dtpSearch.Value < DateTime.Today)
            {
                MessageBox.Show("Appointment Date must be a today or future date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpSearch.Focus();
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
        }

        private void grdAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(grdAppointments.Rows[e.RowIndex].Cells[0].Value);
            Appointment appointment = Appointment.GetAppointmentByID(ID);
        }

        private void frmCancelAppointment_Load(object sender, EventArgs e)
        {
            dtpSearch.Value = DateTime.Today;
        }
    }
}
