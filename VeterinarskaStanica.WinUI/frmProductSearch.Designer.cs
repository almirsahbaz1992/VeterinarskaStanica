namespace VeterinarskaStanica.WinUI
{
	partial class frmProductSearch
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
			txtNaziv = new TextBox();
			txtSifra = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btnSearch = new Button();
			dgProizvodi = new DataGridView();
			Naziv = new DataGridViewTextBoxColumn();
			Sifra = new DataGridViewTextBoxColumn();
			Cijena = new DataGridViewTextBoxColumn();
			Slika = new DataGridViewImageColumn();
			Status = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgProizvodi).BeginInit();
			SuspendLayout();
			// 
			// txtNaziv
			// 
			txtNaziv.Location = new Point(150, 23);
			txtNaziv.Name = "txtNaziv";
			txtNaziv.Size = new Size(170, 27);
			txtNaziv.TabIndex = 0;
			// 
			// txtSifra
			// 
			txtSifra.Location = new Point(459, 24);
			txtSifra.Name = "txtSifra";
			txtSifra.Size = new Size(179, 27);
			txtSifra.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 27);
			label1.Name = "label1";
			label1.Size = new Size(117, 20);
			label1.TabIndex = 2;
			label1.Text = "Naziv proizvoda";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(343, 27);
			label2.Name = "label2";
			label2.Size = new Size(110, 20);
			label2.TabIndex = 3;
			label2.Text = "Šifra proizvoda";
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(676, 23);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(94, 29);
			btnSearch.TabIndex = 4;
			btnSearch.Text = "Pretraga";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// dgProizvodi
			// 
			dgProizvodi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgProizvodi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgProizvodi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Sifra, Cijena, Slika, Status });
			dgProizvodi.Location = new Point(27, 88);
			dgProizvodi.Name = "dgProizvodi";
			dgProizvodi.RowHeadersWidth = 51;
			dgProizvodi.RowTemplate.Height = 29;
			dgProizvodi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgProizvodi.Size = new Size(743, 338);
			dgProizvodi.TabIndex = 5;
			dgProizvodi.CellContentDoubleClick += dgProizvodi_CellContentDoubleClick;
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
			Slika.Resizable = DataGridViewTriState.True;
			Slika.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// Status
			// 
			Status.DataPropertyName = "Status";
			Status.HeaderText = "Status";
			Status.MinimumWidth = 6;
			Status.Name = "Status";
			// 
			// frmProductSearch
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgProizvodi);
			Controls.Add(btnSearch);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtSifra);
			Controls.Add(txtNaziv);
			Name = "frmProductSearch";
			Text = "Pretraga proizvoda";
			((System.ComponentModel.ISupportInitialize)dgProizvodi).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtNaziv;
		private TextBox txtSifra;
		private Label label1;
		private Label label2;
		private Button btnSearch;
		private DataGridView dgProizvodi;
		private DataGridViewTextBoxColumn Naziv;
		private DataGridViewTextBoxColumn Sifra;
		private DataGridViewTextBoxColumn Cijena;
		private DataGridViewImageColumn Slika;
		private DataGridViewTextBoxColumn Status;
	}
}