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

            if (cmbPatientName.Text == "")
            {
                MessageBox.Show("Patient must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPatientName.Focus();
                return;
            }
            else if (cmbDentistName.Text == "")
            {
                MessageBox.Show("Dentist must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDentistName.Focus();
                return;
            }
            else if (cmbServiceTitle.Text == "")
            {

                MessageBox.Show("Service title must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbServiceTitle.Focus();
                return;
            }
            else if (dtpAppointmentDate.Value.Equals(DateTime.Today))
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
            else if (txtComplaint.Text.Equals(""))
            {
                MessageBox.Show("Complaint must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComplaint.Focus();
                return;
            }

            string patientId = cmbPatientName.SelectedValue?.ToString();
            string dentistId = cmbDentistName.SelectedValue?.ToString();
            string serviceId = cmbServiceTitle.SelectedValue?.ToString();

            patientId = (patientId ?? "").Trim();
            dentistId = (dentistId ?? "").Trim();
            serviceId = (serviceId ?? "").Trim();

            Appointment appointment = new Appointment(Convert.ToInt32(txtAppointmentID.Text), patientId, dentistId, serviceId, dtpAppointmentDate.Value, txtComplaint.Text);
            appointment.AddAppointment();

            MessageBox.Show("Apointment added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAppointmentID.Text = Appointment.GetNextAppointmentID().ToString("00");
            cmbPatientName.SelectedIndex = -1;
            cmbDentistName.SelectedIndex = -1;
            cmbServiceTitle.SelectedIndex = -1;
            txtComplaint.Clear();
            dtpAppointmentDate.Value = DateTime.Now;
            cmbPatientName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmMakeAppointment_Load(object sender, EventArgs e)
        {
            txtAppointmentID.Text = Appointment.GetNextAppointmentID().ToString("00");


            DataSet dentists = Dentist.getDentists();
            DataSet patients = Patient.getPatients();
            DataSet services = Service.getServices();

            cmbDentistName.Items.Clear();
            cmbPatientName.Items.Clear();
            cmbServiceTitle.Items.Clear();

                for (int i = 0; i < patients.Tables[0].Rows.Count; i++)
    
                {
    
                    cmbPatientName.Items.Add(patients.Tables[0].Rows[i][0] + " - " + patients.Tables[0].Rows[i][1]);
    
                }
                for (int i = 0; i < services.Tables[0].Rows.Count; i++)
    
                {
    
                    cmbServiceTitle.Items.Add(services.Tables[0].Rows[i][0] + " - " + services.Tables[0].Rows[i][1]);

                 }


                for (int i = 0; i < dentists.Tables[0].Rows.Count; i++)

                {

                cmbDentistName.Items.Add(dentists.Tables[0].Rows[i][0] + " - " + dentists.Tables[0].Rows[i][1]);

             }
        }
    }
}
