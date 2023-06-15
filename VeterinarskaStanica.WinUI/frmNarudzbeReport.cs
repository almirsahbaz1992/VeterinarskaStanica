using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmNarudzbeReport : Form
	{
		public frmNarudzbeReport()
		{
			InitializeComponent();
		}

		private void frmNarudzbeReport_Load(object sender, EventArgs e)
		{
			NarudzbeSet narudzbeSet = new NarudzbeSet();
			string connection = @"Data Source=localhost, 1401;Initial Catalog=VeterinarskaStanica; user=sa; password=QWElkj132!; TrustServerCertificate=true";
			string query = @"SELECT Narudzbe.BrojNarudzbe, Narudzbe.Datum, Narudzbe.Status, Narudzbe.Otkazano, Narudzbe.PaymentId, NarudzbaStavke.Kolicina 
FROM Narudzbe INNER JOIN NarudzbaStavke ON Narudzbe.NarudzbaID = NarudzbaStavke.NarudzbaID";

			SqlConnection sqlConnection = new SqlConnection(connection);
			SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
			adapter.Fill(narudzbeSet, narudzbeSet.Tables[0].TableName);

			ReportDataSource ds = new ReportDataSource("NarudzbeReport", narudzbeSet.Tables[0]);

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(ds);
			reportViewer1.LocalReport.Refresh();
			reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinarskaStanica.WinUI.NarudzbeReport.rdlc";
			reportViewer1.RefreshReport();



		}
	}
}
