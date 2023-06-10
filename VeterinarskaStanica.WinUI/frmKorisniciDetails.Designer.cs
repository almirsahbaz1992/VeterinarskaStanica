namespace VeterinarskaStanica.WinUI
{
	partial class frmKorisniciDetails
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			gbPodaci = new GroupBox();
			txtTelefon = new TextBox();
			lblTelefon = new Label();
			txtEmail = new TextBox();
			txtPrezime = new TextBox();
			txtIme = new TextBox();
			lblEmail = new Label();
			lblPrezime = new Label();
			lblIme = new Label();
			clbUloge = new CheckedListBox();
			cbStatus = new CheckBox();
			btnSave = new Button();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			errorProvider3 = new ErrorProvider(components);
			errorProvider4 = new ErrorProvider(components);
			errorProvider5 = new ErrorProvider(components);
			errorProvider6 = new ErrorProvider(components);
			errorProvider7 = new ErrorProvider(components);
			lblUsername = new Label();
			lblPassword = new Label();
			lblPotvrda = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			txtPotvrda = new TextBox();
			gbPristupniPodaci = new GroupBox();
			errorProvider8 = new ErrorProvider(components);
			gbPodaci.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
			gbPristupniPodaci.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider8).BeginInit();
			SuspendLayout();
			// 
			// gbPodaci
			// 
			gbPodaci.Controls.Add(txtTelefon);
			gbPodaci.Controls.Add(lblTelefon);
			gbPodaci.Controls.Add(txtEmail);
			gbPodaci.Controls.Add(txtPrezime);
			gbPodaci.Controls.Add(txtIme);
			gbPodaci.Controls.Add(lblEmail);
			gbPodaci.Controls.Add(lblPrezime);
			gbPodaci.Controls.Add(lblIme);
			gbPodaci.Location = new Point(17, 15);
			gbPodaci.Name = "gbPodaci";
			gbPodaci.Size = new Size(397, 176);
			gbPodaci.TabIndex = 0;
			gbPodaci.TabStop = false;
			gbPodaci.Text = "Podaci";
			// 
			// txtTelefon
			// 
			txtTelefon.Location = new Point(156, 143);
			txtTelefon.Name = "txtTelefon";
			txtTelefon.Size = new Size(224, 27);
			txtTelefon.TabIndex = 7;
			txtTelefon.Validating += txtTelefon_Validating;
			// 
			// lblTelefon
			// 
			lblTelefon.AutoSize = true;
			lblTelefon.Location = new Point(6, 146);
			lblTelefon.Name = "lblTelefon";
			lblTelefon.Size = new Size(58, 20);
			lblTelefon.TabIndex = 6;
			lblTelefon.Text = "Telefon";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(156, 102);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(224, 27);
			txtEmail.TabIndex = 5;
			txtEmail.Validating += txtEmail_Validating;
			// 
			// txtPrezime
			// 
			txtPrezime.Location = new Point(156, 64);
			txtPrezime.Name = "txtPrezime";
			txtPrezime.Size = new Size(224, 27);
			txtPrezime.TabIndex = 4;
			txtPrezime.Validating += txtPrezime_Validating;
			// 
			// txtIme
			// 
			txtIme.Location = new Point(156, 25);
			txtIme.Name = "txtIme";
			txtIme.Size = new Size(224, 27);
			txtIme.TabIndex = 3;
			txtIme.Validating += txtIme_Validating;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(6, 109);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(52, 20);
			lblEmail.TabIndex = 2;
			lblEmail.Text = "E-mail";
			// 
			// lblPrezime
			// 
			lblPrezime.AutoSize = true;
			lblPrezime.Location = new Point(6, 71);
			lblPrezime.Name = "lblPrezime";
			lblPrezime.Size = new Size(62, 20);
			lblPrezime.TabIndex = 1;
			lblPrezime.Text = "Prezime";
			// 
			// lblIme
			// 
			lblIme.AutoSize = true;
			lblIme.Location = new Point(6, 32);
			lblIme.Name = "lblIme";
			lblIme.Size = new Size(34, 20);
			lblIme.TabIndex = 0;
			lblIme.Text = "Ime";
			// 
			// clbUloge
			// 
			clbUloge.FormattingEnabled = true;
			clbUloge.Items.AddRange(new object[] { "Uloge" });
			clbUloge.Location = new Point(17, 358);
			clbUloge.Name = "clbUloge";
			clbUloge.Size = new Size(150, 114);
			clbUloge.TabIndex = 7;
			clbUloge.Validating += clbUloge_Validating;
			// 
			// cbStatus
			// 
			cbStatus.AutoSize = true;
			cbStatus.Location = new Point(184, 358);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(230, 24);
			cbStatus.TabIndex = 8;
			cbStatus.Text = "Aktivacija/deaktivacija naloga";
			cbStatus.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(303, 443);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 9;
			btnSave.Text = "Sačuvaj";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			errorProvider2.ContainerControl = this;
			// 
			// errorProvider3
			// 
			errorProvider3.ContainerControl = this;
			// 
			// errorProvider4
			// 
			errorProvider4.ContainerControl = this;
			// 
			// errorProvider5
			// 
			errorProvider5.ContainerControl = this;
			// 
			// errorProvider6
			// 
			errorProvider6.ContainerControl = this;
			// 
			// errorProvider7
			// 
			errorProvider7.ContainerControl = this;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(6, 32);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(106, 20);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "Korisničko Ime";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new Point(6, 71);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(59, 20);
			lblPassword.TabIndex = 1;
			lblPassword.Text = "Lozinka";
			// 
			// lblPotvrda
			// 
			lblPotvrda.AutoSize = true;
			lblPotvrda.Location = new Point(6, 109);
			lblPotvrda.Name = "lblPotvrda";
			lblPotvrda.Size = new Size(59, 20);
			lblPotvrda.TabIndex = 2;
			lblPotvrda.Text = "Potvrda";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(156, 25);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(224, 27);
			txtUsername.TabIndex = 3;
			txtUsername.Validating += txtUsername_Validating;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(156, 64);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(224, 27);
			txtPassword.TabIndex = 4;
			txtPassword.Validating += txtPassword_Validating;
			// 
			// txtPotvrda
			// 
			txtPotvrda.Location = new Point(156, 102);
			txtPotvrda.Name = "txtPotvrda";
			txtPotvrda.PasswordChar = '*';
			txtPotvrda.Size = new Size(224, 27);
			txtPotvrda.TabIndex = 5;
			txtPotvrda.Validating += txtPotvrda_Validating;
			// 
			// gbPristupniPodaci
			// 
			gbPristupniPodaci.Controls.Add(txtPotvrda);
			gbPristupniPodaci.Controls.Add(txtPassword);
			gbPristupniPodaci.Controls.Add(txtUsername);
			gbPristupniPodaci.Controls.Add(lblPotvrda);
			gbPristupniPodaci.Controls.Add(lblPassword);
			gbPristupniPodaci.Controls.Add(lblUsername);
			gbPristupniPodaci.Location = new Point(17, 207);
			gbPristupniPodaci.Name = "gbPristupniPodaci";
			gbPristupniPodaci.Size = new Size(397, 141);
			gbPristupniPodaci.TabIndex = 6;
			gbPristupniPodaci.TabStop = false;
			gbPristupniPodaci.Text = "Pristupni podaci";
			// 
			// errorProvider8
			// 
			errorProvider8.ContainerControl = this;
			// 
			// frmKorisniciDetails
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(427, 478);
			Controls.Add(btnSave);
			Controls.Add(cbStatus);
			Controls.Add(clbUloge);
			Controls.Add(gbPristupniPodaci);
			Controls.Add(gbPodaci);
			Name = "frmKorisniciDetails";
			Text = "Podaci o korisniku";
			Load += frmKorisniciDetails_Load;
			gbPodaci.ResumeLayout(false);
			gbPodaci.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
			gbPristupniPodaci.ResumeLayout(false);
			gbPristupniPodaci.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider8).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox gbPodaci;
		private TextBox txtEmail;
		private TextBox txtPrezime;
		private TextBox txtIme;
		private Label lblEmail;
		private Label lblPrezime;
		private Label lblIme;
		private CheckedListBox clbUloge;
		private CheckBox cbStatus;
		private Button btnSave;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
		private ErrorProvider errorProvider3;
		private ErrorProvider errorProvider4;
		private ErrorProvider errorProvider5;
		private ErrorProvider errorProvider6;
		private ErrorProvider errorProvider7;
		private Label label2;
		private Label lblTelefon;
		private TextBox txtTelefon;
		private GroupBox gbPristupniPodaci;
		private TextBox txtPotvrda;
		private TextBox txtPassword;
		private TextBox txtUsername;
		private Label lblPotvrda;
		private Label lblPassword;
		private Label lblUsername;
		private ErrorProvider errorProvider8;
	}
}