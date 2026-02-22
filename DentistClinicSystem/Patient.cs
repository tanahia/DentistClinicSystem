using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
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
        // Replace all occurrences of 'DateOfBirth.Value' with 'DateOfBirth' since DateOfBirth is of type DateTime, not Nullable<DateTime>.
        // Also, to ensure correct SQL formatting, use DateOfBirth.ToString("yyyy-MM-dd") for the SQL string.

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
    }
}
