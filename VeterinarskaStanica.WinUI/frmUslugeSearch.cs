using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.SearchObjects;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmUslugeSearch : Form
	{
		public APIService UslugeService { get; set; } = new APIService("Usluge");
		public frmUslugeSearch()
		{
			InitializeComponent();
			dgUsluge.AutoGenerateColumns = false;
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dgUsluge.Columns.Count; i++)
				if (dgUsluge.Columns[i] is DataGridViewImageColumn)
				{
					((DataGridViewImageColumn)dgUsluge.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
					break;
				}
			var searchObject = new UslugeSearchObject();
			searchObject.Naziv = txtNaziv.Text;
			searchObject.Sifra = txtSifra.Text;
			var list = await UslugeService.Get<List<Usluge>>(searchObject);
			dgUsluge.DataSource = list;
		}

		private void dgUsluge_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var item = dgUsluge.SelectedRows[0].DataBoundItem as Usluge;
			frmUslugeDetails frm = new frmUslugeDetails(item);
			frm.ShowDialog();

		}
	}
}
