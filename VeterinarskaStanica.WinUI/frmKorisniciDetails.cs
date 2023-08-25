using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmKorisniciDetails : Form
	{
		public APIService KorisniciService { get; set; } = new APIService("Korisnici");
		public APIService RoleService { get; set; } = new APIService("Uloge");

		private Korisnici _model = null;

		public frmKorisniciDetails(Korisnici model = null)
		{
			InitializeComponent();
			_model = model;
			cbStatus.Checked = true;
			ActiveControl = cbStatus;
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidateChildren())
			{
				
				var roleList = clbUloge.CheckedItems.Cast<Uloge>().ToList();
				var roleIdList = roleList.Select(x => x.UlogaId).ToList();
				if (_model == null)
				{
					KorisniciInsertRequest insertRequest = new KorisniciInsertRequest()
					{
						Ime = txtIme.Text,
						Prezime = txtPrezime.Text,
						Email = txtEmail.Text,
						Telefon = txtTelefon.Text,
						KorisnickoIme = txtUsername.Text,
						Password = txtPassword.Text,
						PasswordPotvrda = txtPotvrda.Text,
						Status = cbStatus.Checked,
						UlogeIdList = roleIdList,
					};
					if (txtPassword.Text != txtPotvrda.Text)
					{
						MessageBox.Show("Polja lozinka i potvrda lozinke moraju biti identična!");
					}
					else
					{
							var user = await KorisniciService.Post<Korisnici>(insertRequest);
							if(user == null)
							{
								txtEmail.Text = "";
								txtUsername.Text = "";
							}
							else
							{
								txtIme.Text = "";
								txtPrezime.Text = "";
								txtEmail.Text = "";
								txtTelefon.Text = "";
								txtUsername.Text = "";
								txtPassword.Text = "";
								txtPotvrda.Text = "";
								cbStatus.Checked = false;
								MessageBox.Show("Uspješno ste dodali novog korisnika!");
							}

					}

				}
				else
				{
                    KorisniciUpdateRequest updateRequest = new KorisniciUpdateRequest()
					{

						Ime = txtIme.Text,
						Prezime = txtPrezime.Text,
						Telefon = txtTelefon.Text,
						Password = txtPassword.Text,
						PasswordPotvrda = txtPotvrda.Text,
						Status = cbStatus.Checked,
					};

					_model = await KorisniciService.Put<Korisnici>(_model.KorisnikId, updateRequest);
					MessageBox.Show("Uspješno ste ažurirali korisničke podatke!");
				}
			}
		}


		private async void frmKorisniciDetails_Load(object sender, EventArgs e)
		{
			await LoadRoles();
			if (_model != null)
			{
				txtIme.Text = _model.Ime;
				txtPrezime.Text = _model.Prezime;
				txtEmail.Text = _model.Email;
				txtEmail.ReadOnly = true;
				txtTelefon.Text = _model.Telefon;
				txtUsername.Text = _model.KorisnickoIme;
				txtUsername.ReadOnly = true;
				cbStatus.Checked = _model.Status.GetValueOrDefault(false);
			}
		}

		private async Task LoadRoles()
		{
			var roles = await RoleService.Get<List<Uloge>>();
			clbUloge.DataSource = roles;
			clbUloge.DisplayMember = "Naziv";
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

		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				e.Cancel = true;
				txtEmail.Focus();
				errorProvider3.SetError(txtEmail, "Polje e-mail je obavezno!");
			}

			else if (txtEmail.Text.Length > 0 && txtEmail.Text.Trim().Length != 0)
			{
				if (!rEmail.IsMatch(txtEmail.Text.Trim()))
				{
					errorProvider3.SetError(txtEmail, "Format e-mail adrese nije ispravan!");
					e.Cancel = true;
				}
				else
				{
					e.Cancel = false;
					errorProvider3.SetError(txtEmail, "");
				}
			}
			else
			{
				e.Cancel = false;
				errorProvider3.SetError(txtEmail, "");
			}
		}

		private void txtUsername_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rUsername = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.-]*$");
			if (string.IsNullOrWhiteSpace(txtUsername.Text))
			{
				e.Cancel = true;
				txtUsername.Focus();
				errorProvider4.SetError(txtUsername, "Polje korisničko ime je obavezno!");
			}
			else if (!rUsername.IsMatch(txtUsername.Text.Trim()))
				{
					errorProvider4.SetError(txtUsername, "Korisničko ime može sadržavati samo slova bez afrikata i/ili brojeve!");
					e.Cancel = true;
				}
			else if (txtUsername.Text.Length < 4)
			{
				errorProvider4.SetError(txtUsername, "Korisničko ime mora sadržavati više 4 ili više karaktera!");
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider4.SetError(txtUsername, "");
			}
		}

		private void txtPassword_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rPassword = new System.Text.RegularExpressions.Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				e.Cancel = true;
				txtPassword.Focus();
				errorProvider5.SetError(txtPassword, "Polje lozinka je obavezno!");
			}
			else if (txtPassword.Text.Length < 8)
			{
				errorProvider5.SetError(txtPassword, "Lozinka mora sadržavati 8 ili više karaktera!");
				e.Cancel = true;
			}
			else if (!rPassword.IsMatch(txtPassword.Text.Trim()))
			{
				errorProvider5.SetError(txtPassword, "Lozinka mora sadržavati najmanje jedno veliko slovo, jedno malo slovo, jedan broj i jedan specijalni karakter!");
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider5.SetError(txtPassword, "");
			}
		}

		private void txtPotvrda_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rPotvrda = new System.Text.RegularExpressions.Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
			if (string.IsNullOrWhiteSpace(txtPotvrda.Text))
			{
				e.Cancel = true;
				txtPotvrda.Focus();
				errorProvider6.SetError(txtPotvrda, "Polje potvrda lozinke je obavezno!");
			}
			else if (txtPotvrda.Text.Length < 8)
			{
				errorProvider6.SetError(txtPotvrda, "Potvrda lozinke mora sadržavati 8 ili više karaktera!");
				e.Cancel = true;
			}
			else if (!rPotvrda.IsMatch(txtPotvrda.Text.Trim()))
			{
				errorProvider6.SetError(txtPotvrda, "Potvrda lozinke mora sadržavati najmanje jedno veliko slovo, jedno malo slovo, jedan broj i jedan specijalni karakter!");
				e.Cancel = true;
			}
			else
			{
				e.Cancel = false;
				errorProvider6.SetError(txtPotvrda, "");
			}
		}

		private void clbUloge_Validating(object sender, CancelEventArgs e)
		{
			if (clbUloge.CheckedItems.Count == 0)
			{
				e.Cancel = true;
				clbUloge.Focus();
				errorProvider7.SetError(clbUloge, "Polje odabir uloge korisnika je obavezno!");
			}
		}

		private void txtTelefon_Validating(object sender, CancelEventArgs e)
		{
			System.Text.RegularExpressions.Regex rTelefon = new System.Text.RegularExpressions.Regex(@"^\(?([0-9]{3})\)?[/. ]?([0-9]{3})[-. ]?([0-9]{3})$|^\(?([0-9]{3})\)?[/. ]?([0-9]{3})[-. ]?([0-9]{4})$");
			if (string.IsNullOrWhiteSpace(txtTelefon.Text))
			{
				e.Cancel = true;
				txtTelefon.Focus();
				errorProvider8.SetError(txtTelefon, "Polje telefon je obavezno!");
			}
			else if (txtTelefon.Text.Length > 0 && txtTelefon.Text.Trim().Length != 0)
			{
				if (!rTelefon.IsMatch(txtTelefon.Text.Trim()))
				{
					errorProvider8.SetError(txtTelefon, "Format telefonskog broja nije ispravan!\nIspravan format XXX/XXX-XXX ili XXX/XXX-XXXX");
					e.Cancel = true;
				}
				else
				{
					e.Cancel = false;
					errorProvider8.SetError(txtTelefon, "");
				}
			}
			else
			{
				e.Cancel = false;
				errorProvider8.SetError(txtTelefon, "");
			}
		}
    }

}
