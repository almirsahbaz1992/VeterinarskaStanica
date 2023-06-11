namespace VeterinarskaStanica.WinUI
{
	partial class frmUslugeSearch
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
			btnSearch = new Button();
			txtSifra = new TextBox();
			txtNaziv = new TextBox();
			label1 = new Label();
			label2 = new Label();
			dgUsluge = new DataGridView();
			Naziv = new DataGridViewTextBoxColumn();
			Sifra = new DataGridViewTextBoxColumn();
			Cijena = new DataGridViewTextBoxColumn();
			Slika = new DataGridViewImageColumn();
			Status = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgUsluge).BeginInit();
			SuspendLayout();
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(677, 33);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(94, 29);
			btnSearch.TabIndex = 0;
			btnSearch.Text = "Pretraga";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSifra
			// 
			txtSifra.Location = new Point(433, 34);
			txtSifra.Name = "txtSifra";
			txtSifra.Size = new Size(177, 27);
			txtSifra.TabIndex = 1;
			// 
			// txtNaziv
			// 
			txtNaziv.Location = new Point(138, 34);
			txtNaziv.Name = "txtNaziv";
			txtNaziv.Size = new Size(167, 27);
			txtNaziv.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 37);
			label1.Name = "label1";
			label1.Size = new Size(93, 20);
			label1.TabIndex = 3;
			label1.Text = "Naziv usluge";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(330, 37);
			label2.Name = "label2";
			label2.Size = new Size(86, 20);
			label2.TabIndex = 4;
			label2.Text = "Šifra usluge";
			// 
			// dgUsluge
			// 
			dgUsluge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgUsluge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgUsluge.Columns.AddRange(new DataGridViewColumn[] { Naziv, Sifra, Cijena, Slika, Status });
			dgUsluge.Location = new Point(27, 89);
			dgUsluge.Name = "dgUsluge";
			dgUsluge.RowHeadersWidth = 51;
			dgUsluge.RowTemplate.Height = 29;
			dgUsluge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgUsluge.Size = new Size(744, 337);
			dgUsluge.TabIndex = 5;
			dgUsluge.CellContentDoubleClick += dgUsluge_CellContentDoubleClick;
			// 
			// Naziv
			// 
			Naziv.DataPropertyName = "Naziv";
			Naziv.HeaderText = "Naziv";
			Naziv.MinimumWidth = 6;
			Naziv.Name = "Naziv";
			// 
			// Sifra
			// 
			Sifra.DataPropertyName = "Sifra";
			Sifra.HeaderText = "Šifra";
			Sifra.MinimumWidth = 6;
			Sifra.Name = "Sifra";
			// 
			// Cijena
			// 
			Cijena.DataPropertyName = "Cijena";
			Cijena.HeaderText = "Cijena";
			Cijena.MinimumWidth = 6;
			Cijena.Name = "Cijena";
			// 
			// Slika
			// 
			Slika.DataPropertyName = "Slika";
			Slika.HeaderText = "Slika";
			Slika.MinimumWidth = 6;
			Slika.Name = "Slika";
			// 
			// Status
			// 
			Status.DataPropertyName = "Status";
			Status.HeaderText = "Status";
			Status.MinimumWidth = 6;
			Status.Name = "Status";
			// 
			// frmUslugeSearch
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgUsluge);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtNaziv);
			Controls.Add(txtSifra);
			Controls.Add(btnSearch);
			Name = "frmUslugeSearch";
			Text = "Pretraga usluga";
			((System.ComponentModel.ISupportInitialize)dgUsluge).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSearch;
		private TextBox txtSifra;
		private TextBox txtNaziv;
		private Label label1;
		private Label label2;
		private DataGridView dgUsluge;
		private DataGridViewTextBoxColumn Naziv;
		private DataGridViewTextBoxColumn Sifra;
		private DataGridViewTextBoxColumn Cijena;
		private DataGridViewImageColumn Slika;
		private DataGridViewTextBoxColumn Status;
	}
}