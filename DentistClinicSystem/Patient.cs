using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistClinicSystem
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HealthProblems { get; set; }
        public string DentalProblems { get; set; }
        public string Allergies { get; set; }

        public Patient() : this(0, "", "", "", DateTime.Today, "", "", "") { }
        public Patient(int patientID, string fullName, string phone, string address, DateTime dateOfBirth, string healthProblems, string dentalProblems, string allergies)
        {
            PatientID = patientID;
            FullName = fullName;
            Phone = phone;
            Address = address;
            DateOfBirth = dateOfBirth;
            HealthProblems = healthProblems;
            DentalProblems = dentalProblems;
            Allergies = allergies;
        }
       

        public override string ToString()
        {
            return "Patient ID: " + PatientID + "\tFull name: " + FullName + "\tPhone number: " + Phone + "\tAddress: " + Address + "\tDate of Birth: " + DateOfBirth.ToString("dd-MM-yyyy") + "\tHealth Problems: " + HealthProblems + "\tDental Problems: " + DentalProblems + "\tAllergies: " + Allergies;
        }
        public void AddPatient()
        {
            Debug.WriteLine(this);
            string sql = "INSERT INTO PATIENTS Values ( '" +
                PatientID + "','" +
                FullName + "','" +
                Phone + "','" +
                Address + "','" +
                DateOfBirth.ToString("dd-MM-yyyy") + "','" +
                HealthProblems + "','" +
                DentalProblems + "','" +
                Allergies + "')";
            DBConnect.ExecuteNonQuery(sql);
        }
        public static int GetNextPatientID()
        {
            string sql = "SELECT MAX(PATIENTID) FROM PATIENTS";
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

        public static DataSet getPatients()
        {
            String sqlQuery = "SELECT * FROM Patients";
            return DBConnect.ExecuteMultiRowQuery(sqlQuery);
        }
        public static DataSet FindPatients(string name)
        {
            string sqlQuery = "SELECT  PATIENTID, FULLNAME, PHONENUMBER, HOMEADDRESS, DATEOFBIRTH, HEALTHPROBLEMS, DENTALPROBLEMS, ALLERGIES FROM Patients " + "WHERE FULLNAME LIKE '%" + name + "%' ORDER BY FULLNAME";
            return DBConnect.ExecuteMultiRowQuery(sqlQuery);
        }
        public static Patient GetPatientByID(int ID)
        {
            string sqlQuery = "SELECT * FROM Patients WHERE PATIENTID = " + ID;
            OracleDataReader reader = DBConnect.ExecuteSingleRowQuery(sqlQuery);
            reader.Read();
            string fullName = reader.GetString(1);
            string phone = reader.GetString(2);
            string address = reader.GetString(3);
            DateTime dateofbirth = reader.GetDateTime(4);
            string healthproblems = reader.GetString(5);
            string dentalproblems = reader.GetString(6);
            string allergies = reader.GetString(7);
            reader.Close();
            return new Patient(ID, fullName, phone, address, dateofbirth, healthproblems, dentalproblems, allergies);
        }
        public void UpdatePatient()
        {
            string sqlQuery = "UPDATE Patients SET FULLNAME = '" + FullName + "', PHONENUMBER = '" + Phone + "', HOMEADDRESS = '" + Address + "', DATEOFBIRTH = '" + DateOfBirth + "', HEALTHPROBLEMS= '" + HealthProblems + "', DENTALPROBLEMS = '" + DentalProblems+"', ALLERGIES = '" + Allergies + "' WHERE PATIENTID = " + PatientID;
            DBConnect.ExecuteNonQuery(sqlQuery);
        }

        internal void RemovePatient()
        {
            string sqlQuery = "DELETE FROM PATIENTS WHERE PATIENTID = " + PatientID;
            try
            {
                DBConnect.ExecuteNonQuery(sqlQuery);
            }
            catch (OracleException ex) when (ex.Number == 2292)
            {

                string deleteAppointmentsQuery = "DELETE FROM APPOINTMENTS WHERE PATIENTID = " + PatientID;

                DBConnect.ExecuteNonQuery(deleteAppointmentsQuery);

                DBConnect.ExecuteNonQuery(sqlQuery);
            }
        }
    }
}
