namespace VeterinarskaStanica.WinUI
{
	partial class frmKorisnici
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
			btnShow = new Button();
			dgvKorisnici = new DataGridView();
			Ime = new DataGridViewTextBoxColumn();
			Prezime = new DataGridViewTextBoxColumn();
			KorisnickoIme = new DataGridViewTextBoxColumn();
			Email = new DataGridViewTextBoxColumn();
			Telefon = new DataGridViewTextBoxColumn();
			RoleNames = new DataGridViewTextBoxColumn();
			Status = new DataGridViewCheckBoxColumn();
			txtUsername = new TextBox();
			txtName = new TextBox();
			lblUsername = new Label();
			lblName = new Label();
			((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
			SuspendLayout();
			// 
			// btnShow
			// 
			btnShow.Location = new Point(694, 39);
			btnShow.Name = "btnShow";
			btnShow.Size = new Size(94, 29);
			btnShow.TabIndex = 1;
			btnShow.Text = "Prikaži";
			btnShow.UseVisualStyleBackColor = true;
			btnShow.Click += btnShow_Click;
			// 
			// dgvKorisnici
			// 
			dgvKorisnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKorisnici.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, KorisnickoIme, Email, Telefon, RoleNames, Status });
			dgvKorisnici.Location = new Point(19, 74);
			dgvKorisnici.Name = "dgvKorisnici";
			dgvKorisnici.RowHeadersWidth = 51;
			dgvKorisnici.RowTemplate.Height = 29;
			dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvKorisnici.Size = new Size(769, 364);
			dgvKorisnici.TabIndex = 0;
			dgvKorisnici.CellContentDoubleClick += dgvKorisnici_CellContentDoubleClick;
			// 
			// Ime
			// 
			Ime.DataPropertyName = "Ime";
			Ime.HeaderText = "Ime korisnika";
			Ime.MinimumWidth = 6;
			Ime.Name = "Ime";
			// 
			// Prezime
			// 
			Prezime.DataPropertyName = "Prezime";
			Prezime.HeaderText = "Prezime korisnika";
			Prezime.MinimumWidth = 6;
			Prezime.Name = "Prezime";
			// 
			// KorisnickoIme
			// 
			KorisnickoIme.DataPropertyName = "KorisnickoIme";
			KorisnickoIme.HeaderText = "Korisničko ime";
			KorisnickoIme.MinimumWidth = 6;
			KorisnickoIme.Name = "KorisnickoIme";
			// 
			// Email
			// 
			Email.DataPropertyName = "Email";
			Email.HeaderText = "E-mail";
			Email.MinimumWidth = 6;
			Email.Name = "Email";
			// 
			// Telefon
			// 
			Telefon.DataPropertyName = "Telefon";
			Telefon.HeaderText = "Telefon";
			Telefon.MinimumWidth = 6;
			Telefon.Name = "Telefon";
			// 
			// RoleNames
			// 
			RoleNames.DataPropertyName = "RoleNames";
			RoleNames.HeaderText = "Uloga korisnika";
			RoleNames.MinimumWidth = 6;
			RoleNames.Name = "RoleNames";
			// 
			// Status
			// 
			Status.DataPropertyName = "Status";
			Status.HeaderText = "Status";
			Status.MinimumWidth = 6;
			Status.Name = "Status";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(19, 41);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(241, 27);
			txtUsername.TabIndex = 2;
			txtUsername.KeyDown += txtUsername_KeyDown;
			// 
			// txtName
			// 
			txtName.Location = new Point(303, 41);
			txtName.Name = "txtName";
			txtName.Size = new Size(241, 27);
			txtName.TabIndex = 3;
			txtName.KeyDown += txtName_KeyDown;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(19, 18);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(106, 20);
			lblUsername.TabIndex = 4;
			lblUsername.Text = "Korisničko ime";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(303, 18);
			lblName.Name = "lblName";
			lblName.Size = new Size(34, 20);
			lblName.TabIndex = 5;
			lblName.Text = "Ime";
			// 
			// frmKorisnici
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblName);
			Controls.Add(lblUsername);
			Controls.Add(txtName);
			Controls.Add(txtUsername);
			Controls.Add(btnShow);
			Controls.Add(dgvKorisnici);
			Name = "frmKorisnici";
			Text = "Prikaz korisnika";
			((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnShow;
		private DataGridView dgvKorisnici;
		private TextBox txtUsername;
		private TextBox txtName;
		private Label lblUsername;
		private Label lblName;
		private DataGridViewTextBoxColumn Ime;
		private DataGridViewTextBoxColumn Prezime;
		private DataGridViewTextBoxColumn KorisnickoIme;
		private DataGridViewTextBoxColumn Email;
		private DataGridViewTextBoxColumn Telefon;
		private DataGridViewTextBoxColumn RoleNames;
		private DataGridViewCheckBoxColumn Status;
	}
}