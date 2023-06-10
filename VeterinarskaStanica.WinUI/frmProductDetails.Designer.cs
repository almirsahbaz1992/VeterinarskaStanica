namespace VeterinarskaStanica.WinUI
{
	partial class frmProductDetails
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
			txtNaziv = new TextBox();
			txtSifra = new TextBox();
			txtCijena = new TextBox();
			cbVrste = new ComboBox();
			cbJediniceMjere = new ComboBox();
			btnSacuvaj = new Button();
			openFileDialog1 = new OpenFileDialog();
			btnSlika = new Button();
			image = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			errorProvider3 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)image).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
			SuspendLayout();
			// 
			// txtNaziv
			// 
			txtNaziv.Location = new Point(152, 47);
			txtNaziv.Name = "txtNaziv";
			txtNaziv.Size = new Size(186, 27);
			txtNaziv.TabIndex = 0;
			txtNaziv.Validating += txtNaziv_Validating;
			// 
			// txtSifra
			// 
			txtSifra.Location = new Point(152, 85);
			txtSifra.Name = "txtSifra";
			txtSifra.Size = new Size(186, 27);
			txtSifra.TabIndex = 1;
			txtSifra.Validating += txtSifra_Validating;
			// 
			// txtCijena
			// 
			txtCijena.Location = new Point(152, 123);
			txtCijena.Name = "txtCijena";
			txtCijena.Size = new Size(186, 27);
			txtCijena.TabIndex = 2;
			txtCijena.Validating += txtCijena_Validating;
			// 
			// cbVrste
			// 
			cbVrste.FormattingEnabled = true;
			cbVrste.Location = new Point(152, 165);
			cbVrste.Name = "cbVrste";
			cbVrste.Size = new Size(186, 28);
			cbVrste.TabIndex = 3;
			// 
			// cbJediniceMjere
			// 
			cbJediniceMjere.FormattingEnabled = true;
			cbJediniceMjere.Location = new Point(152, 209);
			cbJediniceMjere.Name = "cbJediniceMjere";
			cbJediniceMjere.Size = new Size(186, 28);
			cbJediniceMjere.TabIndex = 4;
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Location = new Point(244, 393);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new Size(94, 29);
			btnSacuvaj.TabIndex = 6;
			btnSacuvaj.Text = "Sačuvaj";
			btnSacuvaj.UseVisualStyleBackColor = true;
			btnSacuvaj.Click += btnSacuvaj_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnSlika
			// 
			btnSlika.Location = new Point(152, 254);
			btnSlika.Name = "btnSlika";
			btnSlika.Size = new Size(186, 29);
			btnSlika.TabIndex = 7;
			btnSlika.Text = "Odaberi sliku proizvoda";
			btnSlika.UseVisualStyleBackColor = true;
			btnSlika.Click += btnSlika_Click;
			// 
			// image
			// 
			image.Location = new Point(396, 21);
			image.Name = "image";
			image.Size = new Size(375, 333);
			image.SizeMode = PictureBoxSizeMode.Zoom;
			image.TabIndex = 8;
			image.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 50);
			label1.Name = "label1";
			label1.Size = new Size(117, 20);
			label1.TabIndex = 9;
			label1.Text = "Naziv proizvoda";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 88);
			label2.Name = "label2";
			label2.Size = new Size(110, 20);
			label2.TabIndex = 10;
			label2.Text = "Šifra proizvoda";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 130);
			label3.Name = "label3";
			label3.Size = new Size(121, 20);
			label3.TabIndex = 11;
			label3.Text = "Cijena proizvoda";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 173);
			label4.Name = "label4";
			label4.Size = new Size(112, 20);
			label4.TabIndex = 12;
			label4.Text = "Vrsta proizvoda";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 212);
			label5.Name = "label5";
			label5.Size = new Size(104, 20);
			label5.TabIndex = 13;
			label5.Text = "Jedinica mjere";
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
			// frmProductDetails
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
			Name = "frmProductDetails";
			Text = "Detalji o proizvodu";
			Load += frmProductDetails_Load;
			((System.ComponentModel.ISupportInitialize)image).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtNaziv;
		private TextBox txtSifra;
		private TextBox txtCijena;
		private ComboBox cbVrste;
		private ComboBox cbJediniceMjere;
		private Button btnSacuvaj;
		private OpenFileDialog openFileDialog1;
		private Button btnSlika;
		private PictureBox image;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
		private ErrorProvider errorProvider3;
	}
}