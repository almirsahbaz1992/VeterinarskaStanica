using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmProductSearch : Form
	{
		public APIService ProizvodiService { get; set; } = new APIService("Proizvodi");
		public frmProductSearch()
		{
			InitializeComponent();
			dgProizvodi.AutoGenerateColumns = false;
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dgProizvodi.Columns.Count; i++)
				if (dgProizvodi.Columns[i] is DataGridViewImageColumn)
				{
					((DataGridViewImageColumn)dgProizvodi.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
					break;
				}
			var searchObject = new ProizvodiSearchObject();
			searchObject.Naziv = txtNaziv.Text;
			searchObject.Sifra = txtSifra.Text;
			var list = await ProizvodiService.Get<List<Proizvodi>>(searchObject);
			dgProizvodi.DataSource = list;
		}

		private void dgProizvodi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var item = dgProizvodi.SelectedRows[0].DataBoundItem as Proizvodi;
			frmProductDetails frm = new frmProductDetails(item);
			frm.ShowDialog();
		}
	}
}
