namespace VeterinarskaStanica.WinUI
{
	partial class MDIMain
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
			menuStrip = new MenuStrip();
			korisniciToolStripMenuItem = new ToolStripMenuItem();
			unosNoToolStripMenuItem = new ToolStripMenuItem();
			pretragaKorisnikaToolStripMenuItem = new ToolStripMenuItem();
			proizvodiToolStripMenuItem = new ToolStripMenuItem();
			unosNovogProizvodaToolStripMenuItem = new ToolStripMenuItem();
			uToolStripMenuItem = new ToolStripMenuItem();
			unosNoveUslugeToolStripMenuItem = new ToolStripMenuItem();
			zaposleniciToolStripMenuItem = new ToolStripMenuItem();
			unosNovogZaposlenikaToolStripMenuItem = new ToolStripMenuItem();
			statusStrip = new StatusStrip();
			toolStripStatusLabel = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			pretragaZaposlenikaToolStripMenuItem = new ToolStripMenuItem();
			menuStrip.SuspendLayout();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.ImageScalingSize = new Size(20, 20);
			menuStrip.Items.AddRange(new ToolStripItem[] { korisniciToolStripMenuItem, proizvodiToolStripMenuItem, uToolStripMenuItem, zaposleniciToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Padding = new Padding(8, 3, 0, 3);
			menuStrip.Size = new Size(843, 30);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "MenuStrip";
			// 
			// korisniciToolStripMenuItem
			// 
			korisniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unosNoToolStripMenuItem, pretragaKorisnikaToolStripMenuItem });
			korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
			korisniciToolStripMenuItem.Size = new Size(79, 24);
			korisniciToolStripMenuItem.Text = "Korisnici";
			// 
			// unosNoToolStripMenuItem
			// 
			unosNoToolStripMenuItem.Name = "unosNoToolStripMenuItem";
			unosNoToolStripMenuItem.Size = new Size(233, 26);
			unosNoToolStripMenuItem.Text = "Unos novog korisnika";
			unosNoToolStripMenuItem.Click += unosNoToolStripMenuItem_Click;
			// 
			// pretragaKorisnikaToolStripMenuItem
			// 
			pretragaKorisnikaToolStripMenuItem.Name = "pretragaKorisnikaToolStripMenuItem";
			pretragaKorisnikaToolStripMenuItem.Size = new Size(233, 26);
			pretragaKorisnikaToolStripMenuItem.Text = "Pretraga korisnika";
			pretragaKorisnikaToolStripMenuItem.Click += pretragaKorisnikaToolStripMenuItem_Click;
			// 
			// proizvodiToolStripMenuItem
			// 
			proizvodiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unosNovogProizvodaToolStripMenuItem });
			proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
			proizvodiToolStripMenuItem.Size = new Size(85, 24);
			proizvodiToolStripMenuItem.Text = "Proizvodi";
			// 
			// unosNovogProizvodaToolStripMenuItem
			// 
			unosNovogProizvodaToolStripMenuItem.Name = "unosNovogProizvodaToolStripMenuItem";
			unosNovogProizvodaToolStripMenuItem.Size = new Size(242, 26);
			unosNovogProizvodaToolStripMenuItem.Text = "Unos novog proizvoda";
			unosNovogProizvodaToolStripMenuItem.Click += unosNovogProizvodaToolStripMenuItem_Click;
			// 
			// uToolStripMenuItem
			// 
			uToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unosNoveUslugeToolStripMenuItem });
			uToolStripMenuItem.Name = "uToolStripMenuItem";
			uToolStripMenuItem.Size = new Size(68, 24);
			uToolStripMenuItem.Text = "Usluge";
			// 
			// unosNoveUslugeToolStripMenuItem
			// 
			unosNoveUslugeToolStripMenuItem.Name = "unosNoveUslugeToolStripMenuItem";
			unosNoveUslugeToolStripMenuItem.Size = new Size(208, 26);
			unosNoveUslugeToolStripMenuItem.Text = "Unos nove usluge";
			unosNoveUslugeToolStripMenuItem.Click += unosNoveUslugeToolStripMenuItem_Click;
			// 
			// zaposleniciToolStripMenuItem
			// 
			zaposleniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unosNovogZaposlenikaToolStripMenuItem, pretragaZaposlenikaToolStripMenuItem });
			zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
			zaposleniciToolStripMenuItem.Size = new Size(99, 24);
			zaposleniciToolStripMenuItem.Text = "Zaposlenici";
			// 
			// unosNovogZaposlenikaToolStripMenuItem
			// 
			unosNovogZaposlenikaToolStripMenuItem.Name = "unosNovogZaposlenikaToolStripMenuItem";
			unosNovogZaposlenikaToolStripMenuItem.Size = new Size(253, 26);
			unosNovogZaposlenikaToolStripMenuItem.Text = "Unos novog zaposlenika";
			unosNovogZaposlenikaToolStripMenuItem.Click += unosNovogZaposlenikaToolStripMenuItem_Click;
			// 
			// statusStrip
			// 
			statusStrip.ImageScalingSize = new Size(20, 20);
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
			statusStrip.Location = new Point(0, 671);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 19, 0);
			statusStrip.Size = new Size(843, 26);
			statusStrip.TabIndex = 2;
			statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			toolStripStatusLabel.Name = "toolStripStatusLabel";
			toolStripStatusLabel.Size = new Size(49, 20);
			toolStripStatusLabel.Text = "Status";
			// 
			// pretragaZaposlenikaToolStripMenuItem
			// 
			pretragaZaposlenikaToolStripMenuItem.Name = "pretragaZaposlenikaToolStripMenuItem";
			pretragaZaposlenikaToolStripMenuItem.Size = new Size(253, 26);
			pretragaZaposlenikaToolStripMenuItem.Text = "Pretraga zaposlenika";
			pretragaZaposlenikaToolStripMenuItem.Click += pretragaZaposlenikaToolStripMenuItem_Click;
			// 
			// MDIMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(843, 697);
			Controls.Add(statusStrip);
			Controls.Add(menuStrip);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip;
			Margin = new Padding(4, 5, 4, 5);
			Name = "MDIMain";
			Text = "Veterinarska Stanica";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		#endregion


		private MenuStrip menuStrip;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabel;
		private ToolTip toolTip;
		private ToolStripMenuItem korisniciToolStripMenuItem;
		private ToolStripMenuItem pretragaKorisnikaToolStripMenuItem;
		private ToolStripMenuItem unosNoToolStripMenuItem;
		private ToolStripMenuItem proizvodiToolStripMenuItem;
		private ToolStripMenuItem unosNovogProizvodaToolStripMenuItem;
		private ToolStripMenuItem uToolStripMenuItem;
		private ToolStripMenuItem unosNoveUslugeToolStripMenuItem;
		private ToolStripMenuItem zaposleniciToolStripMenuItem;
		private ToolStripMenuItem unosNovogZaposlenikaToolStripMenuItem;
		private ToolStripMenuItem pretragaZaposlenikaToolStripMenuItem;
	}
}



