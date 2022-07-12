using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace LibraryMIS
{
    public partial class PrintCYReport : Form
    {
        DataTable dt;
        public PrintCYReport(DataSet1 dd)
        {
            InitializeComponent();
            dt = dd.Tables["book"];
        }

        private void PrintCYReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rsource = new ReportDataSource();
            rsource.Name = "DataSet1";
            rsource.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rsource);
            this.reportViewer1.RefreshReport();
        }
    }
}
