using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistClinicSystem
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public string ServiceTitle { get; set; }
        public string Patient { get; set; }
        public string Dentist { get; set; }
        public DateTime AptDate { get; set; }
        public string Complaint { get; set; }

        public Appointment() : this(0,"", "", "", DateTime.Today, "") { }
        public Appointment(int appointmentID, string service, string patient, string dentist, DateTime aptDate, string complaint)
        {
            AppointmentID = appointmentID;
            ServiceTitle = service;
            Patient = patient;
            Dentist = dentist;    
            AptDate = aptDate;
            Complaint = complaint;
        }
        public override string ToString()
        {
            return "AppointmentID"+AppointmentID+ "\tServiceTitle: " + ServiceTitle + "Patient: " + Patient + "\tDentist: " + Dentist +  "\tAppointment Date: " + AptDate + "\tComplaint: " + Complaint;
        }
        public void AddAppointment()
        {
            string sql = "INSERT INTO APPOINTMENTS Values ( '" +
                AppointmentID + "','" +
                ServiceTitle + "','" +
                Patient + "','" +
                Dentist + "','" +
                AptDate.ToString("dd-MM-yyyy") + "','" +
                Complaint + "')";
            DBConnect.ExecuteNonQuery(sql);
        }
        public static int GetNextAppointmentID()
        {
            string sql = "SELECT MAX(APPOINTMENTID) FROM APPOINTMENTS";
            OracleDataReader reader = DBConnect.ExecuteSingleRowQuery(sql);
            int nextID = 1;
            reader.Read();
            if (reader.IsDBNull(0))
            {
                nextID = 1;
            }
            else
            {
                nextID = reader.GetInt32(0) + 1;
            }
            reader.Close();
            return nextID;
        }
    }
}
