using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
          public static DataSet FindAppointments(DateTime date)
          {
              string sqlQuery = "SELECT appointmentid, appointmentdate, complaint, patients.patientid, patients.fullname, services.serviceid, services.servicetitle, dentists.dentistid, dentists.fullname FROM Appointments " 
                + "INNER JOIN Patients ON appointments.patientid=patients.patientid "
                + "INNER JOIN Dentists ON appointments.dentistid=dentists.dentistid "
                + "INNER JOIN Services ON appointments.serviceid= services.serviceid "
                + "WHERE APPOINTMENTDATE = " +"TO_DATE('"+date.ToString("dd-MM-yyyy") +"', 'dd-MM-yyyy')";
              return DBConnect.ExecuteMultiRowQuery(sqlQuery);
          }
        public static Appointment GetAppointmentByID(int ID)
        {
            string sqlQuery = "SELECT * FROM Appointments WHERE AppointmentID = " + ID;
            OracleDataReader reader = DBConnect.ExecuteSingleRowQuery(sqlQuery);
            reader.Read();
            string serviceid = reader.GetString(1);
            string patientid = reader.GetString(2);
            string dentistid= reader.GetString(3);
            DateTime appointmentdate = reader.GetDateTime(4);
            string complaint = reader.GetString(5);

            reader.Close();
            return new Appointment(ID, serviceid, patientid, dentistid, appointmentdate, complaint);
        }
        public void UpdateAppointment()
        {
            string sqlQuery = "UPDATE Appointments SET APPOINTMENTDATE = '" + AptDate.ToString("dd-MM-yyyy")+ "' WHERE APPOINTMENTID = " + AppointmentID;
            DBConnect.ExecuteNonQuery(sqlQuery);
        }

        internal void CancelAppointment()
        {
          string sqlQuery = "DELETE FROM Appointments WHERE APPOINTMENTID = " + AppointmentID;
            DBConnect.ExecuteNonQuery(sqlQuery);
        }
    }
}
