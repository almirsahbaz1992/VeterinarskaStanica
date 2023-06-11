using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.SearchObjects;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmZaposleniciSearch : Form
	{
		public APIService ZaposleniciService { get; set; } = new APIService("Zaposlenici");
		public frmZaposleniciSearch()
		{
			InitializeComponent();
			dgZaposlenici.AutoGenerateColumns = false;
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			var searchObject = new ZaposleniciSearchObject();
			searchObject.Ime = txtIme.Text;
			searchObject.Prezime = txtPrezime.Text;
			var list = await ZaposleniciService.Get<List<Zaposlenici>>(searchObject);
			dgZaposlenici.DataSource = list;
		}
	}
}
