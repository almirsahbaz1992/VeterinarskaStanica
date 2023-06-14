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
	public partial class frmKorisnici : Form
	{
		public APIService KorisniciService { get; set; } = new APIService("Korisnici");

		public frmKorisnici()
		{
			InitializeComponent();
			dgvKorisnici.AutoGenerateColumns = false;
		}

		private async void btnShow_Click(object sender, EventArgs e)
		{
			var searchObject = new KorisniciSearchObject();
			searchObject.KorisnickoIme = txtUsername.Text;
			searchObject.NameFTS = txtName.Text;
			searchObject.IncludeRoles = true;
			var list = await KorisniciService.Get<List<Korisnici>>(searchObject);
			dgvKorisnici.DataSource = list;
		}

		private void dgvKorisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var item = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnici;
			frmKorisniciDetails frm = new frmKorisniciDetails(item);
			frm.ShowDialog();
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnShow.PerformClick();
		}

		private void txtName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnShow.PerformClick();
		}
	}
}
