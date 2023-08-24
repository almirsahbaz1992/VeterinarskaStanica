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
    public partial class frmZaposleniciReport : Form
    {
        public frmZaposleniciReport()
        {
            InitializeComponent();
        }

        private void frmZaposleniciReport_Load(object sender, EventArgs e)
        {
            ZaposleniciSet zaposleniciSet = new ZaposleniciSet();
            string connection = @"Data Source=localhost, 1401;Initial Catalog=VeterinarskaStanica; user=sa; password=QWElkj132!; TrustServerCertificate=true";
            string query = @"SELECT Ime, Prezime, RadnoMjestoID, DatumZaposlenja, Plata FROM Zaposlenici";

            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            adapter.Fill(zaposleniciSet, zaposleniciSet.Tables[0].TableName);

            ReportDataSource ds = new ReportDataSource("ZaposleniciReport", zaposleniciSet.Tables[0]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinarskaStanica.WinUI.ZaposleniciReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
