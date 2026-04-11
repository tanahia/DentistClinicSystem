using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DentistClinicSystem
{
    public class Service
    {
        public int ServiceID { get; set; }
        public static string DentistID { get; set; }
        public string ServiceTitle { get; set; }
        public decimal Price { get; set; }

        
        public Service() : this(0, "", 0,"") { }
        public Service(int serviceID, string serviceTitle, decimal price, string dentistID)
        {
            ServiceID = serviceID;
            ServiceTitle = serviceTitle;
            Price = price;
            DentistID = dentistID;
        }
        public override string ToString()
        {
            return "Service ID: " + ServiceID + "\tService Title: " + ServiceTitle + "\tPrice: " + Price + "Dentist ID: " + DentistID;
        }
        public void AddService()
        {
            Debug.WriteLine(this);
            string sql = "INSERT INTO SERVICES Values ( '" +
                ServiceID + "','" +
                ServiceTitle + "','" +
                Price + "','" +
                DentistID + "')";
            DBConnect.ExecuteNonQuery(sql);
        }
        public static int GetNextServiceID()
        {
            string sql = "SELECT MAX(SERVICEID) FROM SERVICES";
            OracleDataReader reader = DBConnect.ExecuteSingleRowQuery(sql);
            int nextID;
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
        public static DataSet getServices()
        {
            String sqlQuery = "SELECT * FROM Services";
            return DBConnect.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
