using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DentistClinicSystem
{
    public class Dentist
    {
        public int DentistID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }

        public Dentist() : this(0, "", "", "", "") { }
        public Dentist(int dentistID, string fullName, string phone, string address, string bio)
        {
            DentistID = dentistID;
            FullName = fullName;
            Phone = phone;
            Address = address;
            Bio = bio;
        }
        public override string ToString()
        {
            return "Dentist ID: " + DentistID + "\tFull name: " + FullName + "\tPhone number: " + Phone + "\tAddress: " + Address + "\tBio: " + Bio;
        }
        public void AddDentist()
        {
            Debug.WriteLine(this);
            string sql = "INSERT INTO DENTISTS Values ( '" +
                DentistID + "','" +
                FullName + "','" +
                Phone + "','" +
                Address + "','" +
                Bio + "')";
            DBConnect.ExecuteNonQuery(sql);
        }
        public static int GetNextDentID()
        {
            string sql = "SELECT MAX(DENTISTID) FROM DENTISTS";
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
        public static DataSet getDentists()

        {

            String sqlQuery = "SELECT * FROM Dentists";
            return DBConnect.ExecuteMultiRowQuery(sqlQuery);

        }

       public static DataSet FindDentists(string name)
        {
            string sqlQuery = "SELECT  DENTISTID, FULLNAME, PHONENUMBER, HOMEADDRESS, BIO FROM Dentists " +"WHERE FULLNAME LIKE '%" + name + "%' ORDER BY FULLNAME";
            return DBConnect.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Dentist GetDentistByID(int iD)
        {
            string sqlQuery = "SELECT * FROM Dentists WHERE DENTISTID = " + iD;
            OracleDataReader reader = DBConnect.ExecuteSingleRowQuery(sqlQuery);
            reader.Read();
            string fullName = reader.GetString(1);
            string phone = reader.GetString(2);
            string address = reader.GetString(3);
            string bio = reader.GetString(4);
            reader.Close();
            return new Dentist(iD, fullName, phone, address, bio);
        }

        internal void UpdateDentist()
        {
           string sqlQuery = "UPDATE DENTISTS SET FULLNAME = '" + FullName + "', PHONENUMBER = '" + Phone + "', HOMEADDRESS = '" + Address + "', BIO = '" + Bio + "' WHERE DENTISTID = " + DentistID;
            DBConnect.ExecuteNonQuery(sqlQuery);
        }
    }
}
