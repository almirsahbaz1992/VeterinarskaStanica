using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmZaposlenici : Form
	{
		public APIService ZaposleniciService { get; set; } = new APIService("Zaposlenici");

		public APIService RadnaMjestaService { get; set; } = new APIService("RadnaMjesta");

		private Zaposlenici _model = null;
		public frmZaposlenici(Zaposlenici model = null)
		{
			InitializeComponent();
			_model = model;
		}

		private void txtIme_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtIme.Text))
			{
				e.Cancel = true;
				txtIme.Focus();
				errorProvider1.SetError(txtIme, "Polje ime je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtIme, "");
			}
		}

		private void txtPrezime_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPrezime.Text))
			{
				e.Cancel = true;
				txtPrezime.Focus();
				errorProvider2.SetError(txtPrezime, "Polje prezime je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider2.SetError(txtPrezime, "");
			}
		}

		private void txtPlata_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rPlata = new System.Text.RegularExpressions.Regex(@"^[0-9]*(?:\,[0-9]*)?$");
			if (string.IsNullOrWhiteSpace(txtPlata.Text))
			{
				e.Cancel = true;
				txtPlata.Focus();
				errorProvider4.SetError(txtPlata, "Polje plate zaposlenika je obavezno!");
			}
			else if (txtPlata.Text.Length > 0 && txtPlata.Text.Trim().Length != 0)
			{
				if (!rPlata.IsMatch(txtPlata.Text.Trim()))
				{
					errorProvider4.SetError(txtPlata, "Format plate nije ispravan!\nIspravan decimalni format mora sadržavati , između cifara");
					e.Cancel = true;
				}
				else
				{
					e.Cancel = false;
					errorProvider4.SetError(txtPlata, "");
				}
			}
			else
			{
				e.Cancel = false;
				errorProvider4.SetError(txtPlata, "");
			}
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			var radnaMjestaList = (RadnaMjesta)cbRadnaMjesta.SelectedItem;
			if (txtIme.Text == "" || txtPrezime.Text == "" || txtPlata.Text == "")
			{
				MessageBox.Show("Sva polja moraju biti popunjena");
			}
			else if (_model == null)
			{
				ZaposleniciInsertRequest insertRequest = new ZaposleniciInsertRequest()
				{
					Ime = txtIme.Text,
					Prezime = txtPrezime.Text,
					RadnoMjestoId = radnaMjestaList.RadnaMjestaId,
					DatumZaposlenja = Convert.ToDateTime(dtDatum.Value),
					Plata = float.Parse(txtPlata.Text)
				};
				var product = await ZaposleniciService.Post<Zaposlenici>(insertRequest);
				MessageBox.Show("Uspješno ste dodali novog zaposlenika!");
			}
			else
			{
				ZaposleniciUpdateRequest updateRequest = new ZaposleniciUpdateRequest()
				{
					Prezime = txtPrezime.Text,
					RadnoMjestoId = radnaMjestaList.RadnaMjestaId,
					Plata = float.Parse(txtPlata.Text)
				};
				_model = await ZaposleniciService.Put<Zaposlenici>(_model.ZaposlenikID, updateRequest);
				MessageBox.Show("Uspješno ste ažurirali podatke o zaposleniku!");
			}
		}

		private async void frmZaposlenici_Load(object sender, EventArgs e)
		{
			await LoadRadnaMjesta();
			if (_model != null)
			{
				txtIme.Text = _model.Ime;
				dtDatum.Value = _model.DatumZaposlenja;
				
			}
		}
		private async Task LoadRadnaMjesta()
		{
			var roles = await RadnaMjestaService.Get<List<RadnaMjesta>>();
			cbRadnaMjesta.DataSource = roles;
			cbRadnaMjesta.DisplayMember = "Naziv";
		}
	}
}
