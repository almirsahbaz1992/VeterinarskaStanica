using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmProductDetails : Form
	{
		public APIService ProizvodiService { get; set; } = new APIService("Proizvodi");
		public APIService VrsteService { get; set; } = new APIService("VrsteProizvoda");

		public APIService JedinicaMjereService { get; set; } = new APIService("JediniceMjere");

		private Proizvodi _model = null;
		public frmProductDetails(Proizvodi model = null)
		{
			InitializeComponent();
			_model = model;
		}

		private async void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (ValidateChildren() && image.Image != null)
			{
				var vrsteList = (VrstaProizvoda)cbVrste.SelectedItem;
				var jediniceMjereList = (JediniceMjere)cbJediniceMjere.SelectedItem;
				byte[] slika = (byte[])(new ImageConverter()).ConvertTo(image.Image, typeof(byte[]));
				System.Drawing.Image thumbnail = image.Image.GetThumbnailImage(image.Width, image.Height, null, new System.IntPtr());
				byte[] thumbnailSlika = (byte[])(new ImageConverter()).ConvertTo(thumbnail, typeof(byte[]));

				if (_model == null)
				{
					ProizvodiInsertRequest insertRequest = new ProizvodiInsertRequest()
					{
						Naziv = txtNaziv.Text,
						Sifra = txtSifra.Text,
						Cijena = Decimal.Parse(txtCijena.Text),
						Slika = slika,
						SlikaThumb = thumbnailSlika,
						Opis = rtbOpis.Text,
						PaymentId = "null",
						VrstaId = vrsteList.VrstaId,
						JedinicaMjereId = jediniceMjereList.JedinicaMjereId
					};
					var product = await ProizvodiService.Post<Proizvodi>(insertRequest);
					MessageBox.Show("Uspješno ste dodali novi proizvod!");
				}
				else
				{
					ProizvodiUpdateRequest updateRequest = new ProizvodiUpdateRequest()
					{
						Naziv = txtNaziv.Text,
						Cijena = Decimal.Parse(txtCijena.Text),
						Slika = slika,
						SlikaThumb = thumbnailSlika,
						Opis = rtbOpis.Text,
						Status = true,
						VrstaId = vrsteList.VrstaId,
						JedinicaMjereId = jediniceMjereList.JedinicaMjereId
					};
					_model = await ProizvodiService.Put<Proizvodi>(_model.ProizvodId, updateRequest);
					MessageBox.Show("Uspješno ste ažurirali podatke o proizvodu!");
				}
			}
			else if (image.Image == null)
			{
				MessageBox.Show("Odabir slike je obavezan!");
			}
		}

		private async void frmProductDetails_Load(object sender, EventArgs e)
		{
			await LoadVrste();
			await LoadJediniceMjere();
			if (_model != null)
			{
				cbVrste.SelectedItem = _model.Status.GetValueOrDefault(false);
				cbJediniceMjere.SelectedItem = _model.Status.GetValueOrDefault(false);
				txtSifra.Text = _model.Sifra;
			}
		}

		private async Task LoadVrste()
		{
			var roles = await VrsteService.Get<List<VrstaProizvoda>>();
			cbVrste.DataSource = roles;
			cbVrste.DisplayMember = "Naziv";
		}
		private async Task LoadJediniceMjere()
		{
			var jediniceMjere = await JedinicaMjereService.Get<List<JediniceMjere>>();
			cbJediniceMjere.DataSource = jediniceMjere;
			cbJediniceMjere.DisplayMember = "Naziv";
		}

		private void btnSlika_Click(object sender, EventArgs e)
		{
			String imageLocation = "";
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

				if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					imageLocation = dialog.FileName;
					image.ImageLocation = imageLocation;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Occured", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void txtNaziv_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNaziv.Text))
			{
				e.Cancel = true;
				txtNaziv.Focus();
				errorProvider1.SetError(txtNaziv, "Polje naziv proizvoda je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtNaziv, "");
			}
		}

		private void txtSifra_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtSifra.Text))
			{
				e.Cancel = true;
				txtSifra.Focus();
				errorProvider2.SetError(txtSifra, "Polje šifra proizvoda je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider2.SetError(txtSifra, "");
			}
		}

		private void txtCijena_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rCijena = new System.Text.RegularExpressions.Regex(@"^[0-9]*(?:\,[0-9]*)?$");
			if (string.IsNullOrWhiteSpace(txtCijena.Text))
			{
				e.Cancel = true;
				txtCijena.Focus();
				errorProvider3.SetError(txtCijena, "Polje cijena proizvoda je obavezno!");
			}
			else if (txtCijena.Text.Length > 0 && txtCijena.Text.Trim().Length != 0)
			{
				if (!rCijena.IsMatch(txtCijena.Text.Trim()))
				{
					errorProvider3.SetError(txtCijena, "Format cijene nije ispravan!\nIspravan decimalni format mora sadržavati , između cifara");
					e.Cancel = true;
				}
				else
				{
					e.Cancel = false;
					errorProvider3.SetError(txtCijena, "");
				}
			}
			else
			{
				e.Cancel = false;
				errorProvider3.SetError(txtCijena, "");
			}
		}

		private void rtbOpis_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(rtbOpis.Text))
			{
				e.Cancel = true;
				rtbOpis.Focus();
				errorProvider4.SetError(rtbOpis, "Polje opis proizvoda je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider4.SetError(rtbOpis, "");
			}
		}
	}
}
