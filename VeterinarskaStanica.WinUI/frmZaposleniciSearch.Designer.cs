namespace VeterinarskaStanica.WinUI
{
	partial class frmZaposleniciSearch
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
			txtIme = new TextBox();
			txtPrezime = new TextBox();
			label1 = new Label();
			label2 = new Label();
			btnSearch = new Button();
			dgZaposlenici = new DataGridView();
			Ime = new DataGridViewTextBoxColumn();
			Prezime = new DataGridViewTextBoxColumn();
			RadnoMjesto = new DataGridViewTextBoxColumn();
			DatumZaposlenja = new DataGridViewTextBoxColumn();
			Plata = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgZaposlenici).BeginInit();
			SuspendLayout();
			// 
			// txtIme
			// 
			txtIme.Location = new Point(73, 41);
			txtIme.Name = "txtIme";
			txtIme.Size = new Size(186, 27);
			txtIme.TabIndex = 0;
			// 
			// txtPrezime
			// 
			txtPrezime.Location = new Point(437, 41);
			txtPrezime.Name = "txtPrezime";
			txtPrezime.Size = new Size(195, 27);
			txtPrezime.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(22, 44);
			label1.Name = "label1";
			label1.Size = new Size(34, 20);
			label1.TabIndex = 2;
			label1.Text = "Ime";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(348, 44);
			label2.Name = "label2";
			label2.Size = new Size(62, 20);
			label2.TabIndex = 3;
			label2.Text = "Prezime";
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(693, 40);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(94, 29);
			btnSearch.TabIndex = 4;
			btnSearch.Text = "Pretraga";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// dgZaposlenici
			// 
			dgZaposlenici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgZaposlenici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgZaposlenici.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, RadnoMjesto, DatumZaposlenja, Plata });
			dgZaposlenici.Location = new Point(22, 98);
			dgZaposlenici.Name = "dgZaposlenici";
			dgZaposlenici.RowHeadersWidth = 51;
			dgZaposlenici.RowTemplate.Height = 29;
			dgZaposlenici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgZaposlenici.Size = new Size(765, 331);
			dgZaposlenici.TabIndex = 5;
			dgZaposlenici.CellContentDoubleClick += dgZaposlenici_CellContentDoubleClick;
			// 
			// Ime
			// 
			Ime.DataPropertyName = "Ime";
			Ime.HeaderText = "Ime";
			Ime.MinimumWidth = 6;
			Ime.Name = "Ime";
			// 
			// Prezime
			// 
			Prezime.DataPropertyName = "Prezime";
			Prezime.HeaderText = "Prezime";
			Prezime.MinimumWidth = 6;
			Prezime.Name = "Prezime";
			// 
			// RadnoMjesto
			// 
			RadnoMjesto.DataPropertyName = "RadnoMjestoId";
			RadnoMjesto.HeaderText = "Radno Mjesto";
			RadnoMjesto.MinimumWidth = 6;
			RadnoMjesto.Name = "RadnoMjesto";
			// 
			// DatumZaposlenja
			// 
			DatumZaposlenja.DataPropertyName = "DatumZaposlenja";
			DatumZaposlenja.HeaderText = "Datum zaposlenja";
			DatumZaposlenja.MinimumWidth = 6;
			DatumZaposlenja.Name = "DatumZaposlenja";
			// 
			// Plata
			// 
			Plata.DataPropertyName = "Plata";
			Plata.HeaderText = "Plata";
			Plata.MinimumWidth = 6;
			Plata.Name = "Plata";
			// 
			// frmZaposleniciSearch
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgZaposlenici);
			Controls.Add(btnSearch);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPrezime);
			Controls.Add(txtIme);
			Name = "frmZaposleniciSearch";
			Text = "Pretraga zaposlenika";
			((System.ComponentModel.ISupportInitialize)dgZaposlenici).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtIme;
		private TextBox txtPrezime;
		private Label label1;
		private Label label2;
		private Button btnSearch;
		private DataGridView dgZaposlenici;
		private DataGridViewTextBoxColumn Ime;
		private DataGridViewTextBoxColumn Prezime;
		private DataGridViewTextBoxColumn RadnoMjesto;
		private DataGridViewTextBoxColumn DatumZaposlenja;
		private DataGridViewTextBoxColumn Plata;
	}
}