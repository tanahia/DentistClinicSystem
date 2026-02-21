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

    public partial class frmMakeAppointment : Form
    {
        frmMainMenu parent;
        public frmMakeAppointment()
        {
            InitializeComponent();
        }
        public frmMakeAppointment(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnSave_Click(object sender, EventArgs e)
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
            else if (!int.TryParse(txtPhone.Text, out i) || !txtPhone.Text.StartsWith("+"))
            {
                MessageBox.Show("Phone number must start with '+' and have only numeric characters expect the first character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtDentistFullName.Text.Equals(""))
            {
                MessageBox.Show("Dentist Full Name must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistFullName.Focus();
                return;
            }
            else if (int.TryParse(txtDentistFullName.Text, out i))
            {
                MessageBox.Show("Dentist Full Name must be alphabetic.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDentistFullName.Focus();
                return;
            }
            else if (txtServiceTitle.Text.Equals(""))
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
            else if (txtComplaint.Text.Equals(""))
            {
                MessageBox.Show("Complaint must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComplaint.Focus();
                return;
            }


            MessageBox.Show("Apointment added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFullName.Clear();
            txtDentistFullName.Clear();
            txtPhone.Clear();
            txtServiceTitle.Clear();
            txtComplaint.Clear();
            dtpAppointmentDate.Value = DateTime.Now;
            txtFullName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
