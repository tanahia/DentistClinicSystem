namespace DentistClinicSystem
{
    partial class frmYearlyRevenueAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grpRevenue = new GroupBox();
            revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnDisplay = new Button();
            cmbYear = new ComboBox();
            btnExit = new Button();
            grpRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)revenueChart).BeginInit();
            SuspendLayout();
            // 
            // grpRevenue
            // 
            grpRevenue.Controls.Add(revenueChart);
            grpRevenue.Controls.Add(btnDisplay);
            grpRevenue.Controls.Add(cmbYear);
            grpRevenue.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpRevenue.ForeColor = SystemColors.HotTrack;
            grpRevenue.Location = new Point(23, 27);
            grpRevenue.Name = "grpRevenue";
            grpRevenue.Size = new Size(1003, 545);
            grpRevenue.TabIndex = 0;
            grpRevenue.TabStop = false;
            grpRevenue.Text = "Choose the year for revenue analysis:";
            // 
            // revenueChart
            // 
            chartArea1.Name = "ChartArea1";
            revenueChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            revenueChart.Legends.Add(legend1);
            revenueChart.Location = new Point(33, 138);
            revenueChart.Name = "revenueChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            revenueChart.Series.Add(series1);
            revenueChart.Size = new Size(932, 375);
            revenueChart.TabIndex = 10;
            revenueChart.Text = "revenueChart";
            revenueChart.Visible = false;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = SystemColors.HotTrack;
            btnDisplay.Location = new Point(297, 35);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(158, 54);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "2025" });
            cmbYear.Location = new Point(33, 53);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(151, 30);
            cmbYear.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.HotTrack;
            btnExit.Location = new Point(948, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 33);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmYearlyRevenueAnalysis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 593);
            Controls.Add(btnExit);
            Controls.Add(grpRevenue);
            Name = "frmYearlyRevenueAnalysis";
            Text = "Dentist Clinic System - [Yearly Revenue Analysis]";
            Load += frmYearlyRevenueAnalysis_Load;
            grpRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)revenueChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRevenue;
        private ComboBox cmbYear;
        private Button btnDisplay;
        private Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
    }
}