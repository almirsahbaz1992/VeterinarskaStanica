using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VeterinarskaStanica.WinUI
{
	public partial class frmLogin : Form
	{
		private readonly APIService _api = new APIService("Korisnici");
		public frmLogin()
		{
            InitializeComponent();
			this.CenterToScreen();
        }
		private async void btnLogin_Click(object sender, EventArgs e)
		{
			APIService.Username = txtUsername.Text;
			APIService.Password = txtPassword.Text;
            try
			{
				var result = await _api.Get<dynamic>();
				MDIMain frm = new MDIMain();
				frm.Show();
				this.Hide();
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = "https://localhost:7172/Proizvodi/1/Recommend",
                    UseShellExecute = true
                };
                Process.Start(psInfo);
                Process.Start(psInfo);
            }
			catch (Exception ex)
			{
				MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
			}
		}

		private void txtUsername_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtUsername.Text))
			{
				e.Cancel = true;
				txtUsername.Focus();
				errorProvider1.SetError(txtUsername, "Polje korisničko ime je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(txtUsername, "");
			}
		}

		private void txtPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				e.Cancel = true;
				txtPassword.Focus();
				errorProvider2.SetError(txtPassword, "Polje lozinka je obavezno!");
			}
			else
			{
				e.Cancel = false;
				errorProvider2.SetError(txtPassword, "");
			}
		}

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtPassword.Text != "")
				btnLogin.PerformClick();
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtUsername.Text != "")
				btnLogin.PerformClick();
		}
	}
}
