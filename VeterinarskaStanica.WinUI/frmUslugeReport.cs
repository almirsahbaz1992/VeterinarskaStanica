using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarskaStanica.WinUI
{
    public partial class frmUslugeReport : Form
    {
        public frmUslugeReport()
        {
            InitializeComponent();
        }

        private void frmUslugeReport_Load(object sender, EventArgs e)
        {
            UslugeSet uslugeSet = new UslugeSet();
            string connection = @"Data Source=localhost, 1401;Initial Catalog=VeterinarskaStanica; user=sa; password=QWElkj132!; TrustServerCertificate=true";
            string query = @"SELECT Naziv, Sifra, Cijena, Status FROM Usluge";

            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.Fill(uslugeSet, uslugeSet.Tables[0].TableName);

            ReportDataSource ds = new ReportDataSource("UslugeReport", uslugeSet.Tables[0]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinarskaStanica.WinUI.UslugeReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
