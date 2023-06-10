namespace VeterinarskaStanica.WinUI
{
	partial class frmUslugeDetails
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
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			image = new PictureBox();
			btnSlika = new Button();
			btnSacuvaj = new Button();
			cbJediniceMjere = new ComboBox();
			cbVrste = new ComboBox();
			txtCijena = new TextBox();
			txtSifra = new TextBox();
			txtNaziv = new TextBox();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			errorProvider3 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)image).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(21, 216);
			label5.Name = "label5";
			label5.Size = new Size(104, 20);
			label5.TabIndex = 26;
			label5.Text = "Jedinica mjere";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 177);
			label4.Name = "label4";
			label4.Size = new Size(88, 20);
			label4.TabIndex = 25;
			label4.Text = "Vrsta usluge";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 134);
			label3.Name = "label3";
			label3.Size = new Size(97, 20);
			label3.TabIndex = 24;
			label3.Text = "Cijena usluge";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 92);
			label2.Name = "label2";
			label2.Size = new Size(86, 20);
			label2.TabIndex = 23;
			label2.Text = "Šifra usluge";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 54);
			label1.Name = "label1";
			label1.Size = new Size(93, 20);
			label1.TabIndex = 22;
			label1.Text = "Naziv usluge";
			// 
			// image
			// 
			image.Location = new Point(405, 25);
			image.Name = "image";
			image.Size = new Size(375, 333);
			image.SizeMode = PictureBoxSizeMode.Zoom;
			image.TabIndex = 21;
			image.TabStop = false;
			// 
			// btnSlika
			// 
			btnSlika.Location = new Point(161, 258);
			btnSlika.Name = "btnSlika";
			btnSlika.Size = new Size(186, 29);
			btnSlika.TabIndex = 20;
			btnSlika.Text = "Odaberi sliku usluge";
			btnSlika.UseVisualStyleBackColor = true;
			btnSlika.Click += btnSlika_Click;
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Location = new Point(253, 397);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new Size(94, 29);
			btnSacuvaj.TabIndex = 19;
			btnSacuvaj.Text = "Sačuvaj";
			btnSacuvaj.UseVisualStyleBackColor = true;
			btnSacuvaj.Click += btnSacuvaj_Click;
			// 
			// cbJediniceMjere
			// 
			cbJediniceMjere.FormattingEnabled = true;
			cbJediniceMjere.Location = new Point(161, 213);
			cbJediniceMjere.Name = "cbJediniceMjere";
			cbJediniceMjere.Size = new Size(186, 28);
			cbJediniceMjere.TabIndex = 18;
			// 
			// cbVrste
			// 
			cbVrste.FormattingEnabled = true;
			cbVrste.Location = new Point(161, 169);
			cbVrste.Name = "cbVrste";
			cbVrste.Size = new Size(186, 28);
			cbVrste.TabIndex = 17;
			// 
			// txtCijena
			// 
			txtCijena.Location = new Point(161, 127);
			txtCijena.Name = "txtCijena";
			txtCijena.Size = new Size(186, 27);
			txtCijena.TabIndex = 16;
			txtCijena.Validating += txtCijena_Validating;
			// 
			// txtSifra
			// 
			txtSifra.Location = new Point(161, 89);
			txtSifra.Name = "txtSifra";
			txtSifra.Size = new Size(186, 27);
			txtSifra.TabIndex = 15;
			txtSifra.Validating += txtSifra_Validating;
			// 
			// txtNaziv
			// 
			txtNaziv.Location = new Point(161, 51);
			txtNaziv.Name = "txtNaziv";
			txtNaziv.Size = new Size(186, 27);
			txtNaziv.TabIndex = 14;
			txtNaziv.Validating += txtNaziv_Validating;
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
			// frmUslugeDetails
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(image);
			Controls.Add(btnSlika);
			Controls.Add(btnSacuvaj);
			Controls.Add(cbJediniceMjere);
			Controls.Add(cbVrste);
			Controls.Add(txtCijena);
			Controls.Add(txtSifra);
			Controls.Add(txtNaziv);
			Name = "frmUslugeDetails";
			Text = "Detalji o usluzi";
			Load += frmUslugeDetails_Load;
			((System.ComponentModel.ISupportInitialize)image).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private PictureBox image;
		private Button btnSlika;
		private Button btnSacuvaj;
		private ComboBox cbJediniceMjere;
		private ComboBox cbVrste;
		private TextBox txtCijena;
		private TextBox txtSifra;
		private TextBox txtNaziv;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
		private ErrorProvider errorProvider3;
	}
}