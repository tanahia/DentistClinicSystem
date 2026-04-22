using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    //this class handles all database connections and operations
    class DBConnect
    {
       



 static OracleConnection OpenConnection()
        {
            try
            {
                string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string filePath = Path.Combine(userProfilePath + "\\OneDrive - Munster Technological University", "Documents", "OracleConnectionStringHOME.txt");
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found: {filePath}");
                    return null;
                }
                else
                {
                    string content = File.ReadAllText(filePath);

                    Console.WriteLine("File contents is as follows:\n");

                    Console.WriteLine(content + "\n\n");

                    OracleConnection conn = new OracleConnection(content);
                    if (conn != null)
                    {
                        conn.Open();

                        Console.WriteLine("Connection to Oracle was successful");
                    }
                    return conn;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle error: {ex.Message}");
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied. Try running the app with appropriate permissions.");
                return null;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return null;
            }
        }
        public static DataSet ExecuteMultiRowQuery(string query, OracleParameter[] parameters = null)
        {

            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }
        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static void ExecuteNonQuery(string query)
        {
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

