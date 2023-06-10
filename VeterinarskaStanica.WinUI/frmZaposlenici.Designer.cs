namespace VeterinarskaStanica.WinUI
{
	partial class frmZaposlenici
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
			txtIme = new TextBox();
			txtPrezime = new TextBox();
			txtPlata = new TextBox();
			dtDatum = new DateTimePicker();
			btnSave = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			errorProvider3 = new ErrorProvider(components);
			errorProvider4 = new ErrorProvider(components);
			errorProvider5 = new ErrorProvider(components);
			cbRadnaMjesta = new ComboBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
			SuspendLayout();
			// 
			// txtIme
			// 
			txtIme.Location = new Point(166, 43);
			txtIme.Name = "txtIme";
			txtIme.Size = new Size(187, 27);
			txtIme.TabIndex = 0;
			txtIme.Validating += txtIme_Validating;
			// 
			// txtPrezime
			// 
			txtPrezime.Location = new Point(166, 90);
			txtPrezime.Name = "txtPrezime";
			txtPrezime.Size = new Size(187, 27);
			txtPrezime.TabIndex = 1;
			txtPrezime.Validating += txtPrezime_Validating;
			// 
			// txtPlata
			// 
			txtPlata.Location = new Point(166, 183);
			txtPlata.Name = "txtPlata";
			txtPlata.Size = new Size(187, 27);
			txtPlata.TabIndex = 3;
			txtPlata.Validating += txtPlata_Validating;
			// 
			// dtDatum
			// 
			dtDatum.CustomFormat = "dd.MM.yyyy.";
			dtDatum.Format = DateTimePickerFormat.Custom;
			dtDatum.Location = new Point(166, 241);
			dtDatum.Name = "dtDatum";
			dtDatum.Size = new Size(187, 27);
			dtDatum.TabIndex = 4;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(259, 311);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 5;
			btnSave.Text = "Sačuvaj";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(28, 46);
			label1.Name = "label1";
			label1.Size = new Size(34, 20);
			label1.TabIndex = 6;
			label1.Text = "Ime";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(28, 93);
			label2.Name = "label2";
			label2.Size = new Size(62, 20);
			label2.TabIndex = 7;
			label2.Text = "Prezime";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(28, 142);
			label3.Name = "label3";
			label3.Size = new Size(101, 20);
			label3.TabIndex = 8;
			label3.Text = "Radno mjesto";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(28, 190);
			label4.Name = "label4";
			label4.Size = new Size(81, 20);
			label4.TabIndex = 9;
			label4.Text = "Iznos plate";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 246);
			label5.Name = "label5";
			label5.Size = new Size(129, 20);
			label5.TabIndex = 10;
			label5.Text = "Datum zaposlenja";
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
			// cbRadnaMjesta
			// 
			cbRadnaMjesta.FormattingEnabled = true;
			cbRadnaMjesta.Location = new Point(166, 139);
			cbRadnaMjesta.Name = "cbRadnaMjesta";
			cbRadnaMjesta.Size = new Size(187, 28);
			cbRadnaMjesta.TabIndex = 11;
			// 
			// frmZaposlenici
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(385, 366);
			Controls.Add(cbRadnaMjesta);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnSave);
			Controls.Add(dtDatum);
			Controls.Add(txtPlata);
			Controls.Add(txtPrezime);
			Controls.Add(txtIme);
			Name = "frmZaposlenici";
			Text = "Unos podataka o zaposleniku";
			Load += frmZaposlenici_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtIme;
		private TextBox txtPrezime;
		private TextBox txtPlata;
		private DateTimePicker dtDatum;
		private Button btnSave;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
		private ErrorProvider errorProvider3;
		private ErrorProvider errorProvider4;
		private ErrorProvider errorProvider5;
		private ComboBox cbRadnaMjesta;
	}
}