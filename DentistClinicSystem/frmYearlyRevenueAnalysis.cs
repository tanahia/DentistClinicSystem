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
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DentistClinicSystem
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMainMenu parent;

        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cmbYear.Text == "")
            {
                MessageBox.Show("Please select a year to display report.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbYear.Focus();
                return;
            }
            
            string year = cmbYear.SelectedItem.ToString();

            string query =
            "SELECT SUM(PRICE), TO_CHAR(APPOINTMENTDATE, 'MM') AS MONTH_NUM " +
            "FROM APPOINTMENTS " +
            "WHERE APPOINTMENTDATE >= TO_DATE(:startDate, 'YYYY-MM-DD') " +
            "AND APPOINTMENTDATE < TO_DATE(:endDate, 'YYYY-MM-DD') " +
            "GROUP BY TO_CHAR(APPOINTMENTDATE,'MM') " +
            "ORDER BY TO_CHAR(APPOINTMENTDATE,'MM')";

            /*I have to use oracle parameters because I had issue with timestamp converting to data format*/
            OracleParameter[] parameters = new OracleParameter[]
            {
            new OracleParameter("startDate", year + "-01-01"),
            new OracleParameter("endDate", (Convert.ToInt32(year) + 1) + "-01-01")
            };

            DataSet ds = DBConnect.ExecuteMultiRowQuery(query, parameters);


            revenueChart.Series[0].Points.Clear();

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int monthIndex = Convert.ToInt32(ds.Tables[0].Rows[i][1]);
                decimal value = Convert.ToDecimal(ds.Tables[0].Rows[i][0]);

                revenueChart.Series[0].Points.AddXY(monthIndex, value);
            }
            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN",
                    "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

            foreach (var point in revenueChart.Series[0].Points)
            {
                int m = (int)point.XValue;
                point.AxisLabel = months[m - 1];
            }
            cmbYear.SelectedIndex = -1;
           cmbYear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {

            DataSet appointmentDates = Appointment.getAppointmentDates();
            cmbYear.Items.Clear();

            for (int i = 0; i < appointmentDates.Tables[0].Rows.Count; i++)

            {

              string year=  appointmentDates.Tables[0].Rows[i][0].ToString().Trim().Substring(6, 4);
                if(!cmbYear.Items.Contains(year))
                {
                    cmbYear.Items.Add(year);
                }

            }
            revenueChart.Series[0].LegendText = "Income in €";
            revenueChart.Series[0].Label = "#VALY";
            revenueChart.Titles.Add("Yearly Revenue");
            revenueChart.ChartAreas[0].AxisX.Title = "Month";
            revenueChart.ChartAreas[0].AxisY.Title = "Income";
            revenueChart.Visible = true;
        }
    }
}
