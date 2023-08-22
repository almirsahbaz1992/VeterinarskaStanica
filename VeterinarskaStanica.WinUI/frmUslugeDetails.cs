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
using VeterinarskaStanica.Model.Request;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmUslugeDetails : Form
	{
		public APIService UslugeService { get; set; } = new APIService("Usluge");
		public APIService VrsteService { get; set; } = new APIService("VrsteUsluge");

		public APIService JedinicaMjereService { get; set; } = new APIService("JediniceMjere");

		private Usluge _model = null;
		public frmUslugeDetails(Usluge model = null)
		{
			InitializeComponent();
			_model = model;
			ActiveControl = btnSlika;
        }
		public frmUslugeDetails()
		{
			InitializeComponent();
		}

		private async void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (ValidateChildren() && image.Image != null)
			{
				var vrsteList = (VrsteUsluga)cbVrste.SelectedItem;
				var jediniceMjereList = (JediniceMjere)cbJediniceMjere.SelectedItem;
				byte[] slika = (byte[])(new ImageConverter()).ConvertTo(image.Image, typeof(byte[]));
				System.Drawing.Image thumbnail = image.Image.GetThumbnailImage(image.Width, image.Height, null, new System.IntPtr());
				byte[] thumbnailSlika = (byte[])(new ImageConverter()).ConvertTo(thumbnail, typeof(byte[]));

				if (_model == null)
				{
					UslugeInsertRequest insertRequest = new UslugeInsertRequest()
					{
						Naziv = txtNaziv.Text,
						Sifra = txtSifra.Text,
						Cijena = Decimal.Parse(txtCijena.Text),
						Slika = slika,
						SlikaThumb = thumbnailSlika,
						PaymentId = "null",
						VrstaId = vrsteList.VrstaId,
						JedinicaMjereId = jediniceMjereList.JedinicaMjereId,
						StateMachine = "draft"
					};
					var product = await UslugeService.Post<Usluge>(insertRequest);
					MessageBox.Show("Uspješno ste dodali novu uslugu!");
				}
				else
				{
					UslugeUpdateRequest updateRequest = new UslugeUpdateRequest()
					{
						Naziv = txtNaziv.Text,
						Cijena = Decimal.Parse(txtCijena.Text),
						Slika = slika,
						SlikaThumb = thumbnailSlika,
						VrstaId = vrsteList.VrstaId,
						JedinicaMjereId = jediniceMjereList.JedinicaMjereId,
						Status = true
					};
					_model = await UslugeService.Put<Usluge>(_model.UslugaId, updateRequest);
					MessageBox.Show("Uspješno ste ažurirali podatke o usluzi!");
				}
			}
			else
			{
				MessageBox.Show("Odabir slike je obavezan!");
			}
		}

		private async void frmUslugeDetails_Load(object sender, EventArgs e)
		{
			await LoadVrste();
			await LoadJediniceMjere();
			if (_model != null)
			{
				cbVrste.SelectedItem = _model.Status.GetValueOrDefault(false);
				cbJediniceMjere.SelectedItem = _model.Status.GetValueOrDefault(false);
				txtNaziv.Text = _model.Naziv;
				txtSifra.Text = _model.Sifra;
				txtSifra.ReadOnly = true;
				txtCijena.Text = _model.Cijena.ToString();
				cbVrste.Enabled = false;
				image.Image = ByteToImage(_model.Slika);
			}
		}

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private async Task LoadVrste()
		{
			var roles = await VrsteService.Get<List<VrsteUsluga>>();
			cbVrste.DataSource = roles;
			cbVrste.DisplayMember = "Naziv";
		}
		private async Task LoadJediniceMjere()
		{
			var jediniceMjere = await JedinicaMjereService.Get<List<JediniceMjere>>();
			cbJediniceMjere.DataSource = jediniceMjere;
			cbJediniceMjere.DisplayMember = "Naziv";
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
	}
}
