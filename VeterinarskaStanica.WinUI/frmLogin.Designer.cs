using System.Windows.Forms;

namespace VeterinarskaStanica.WinUI
{
	partial class frmLogin
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
			lblUsername = new Label();
			lblPassword = new Label();
			btnLogin = new Button();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			indeximage = new PictureBox();
			errorProvider1 = new ErrorProvider(components);
			errorProvider2 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)indeximage).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
			SuspendLayout();
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(118, 275);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(106, 20);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "Korisničko ime";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new Point(136, 337);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(59, 20);
			lblPassword.TabIndex = 1;
			lblPassword.Text = "Lozinka";
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(74, 419);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(191, 29);
			btnLogin.TabIndex = 2;
			btnLogin.Text = "Pristupi";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(74, 298);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(191, 27);
			txtUsername.TabIndex = 3;
			txtUsername.KeyDown += txtUsername_KeyDown;
			txtUsername.Validating += txtUsername_Validating;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(74, 360);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(191, 27);
			txtPassword.TabIndex = 4;
			txtPassword.KeyDown += txtPassword_KeyDown;
			txtPassword.Validating += txtPassword_Validating;
			// 
			// indeximage
			// 
			indeximage.Image = Properties.Resources.index;
			indeximage.Location = new Point(45, 12);
			indeximage.Name = "indeximage";
			indeximage.Size = new Size(250, 250);
			indeximage.SizeMode = PictureBoxSizeMode.StretchImage;
			indeximage.TabIndex = 5;
			indeximage.TabStop = false;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			errorProvider2.ContainerControl = this;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(326, 460);
			Controls.Add(indeximage);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(btnLogin);
			Controls.Add(lblPassword);
			Controls.Add(lblUsername);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Name = "frmLogin";
			Text = "Pristup sistemu";
			((System.ComponentModel.ISupportInitialize)indeximage).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUsername;
		private Label lblPassword;
		private Button btnLogin;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private PictureBox indeximage;
		private ErrorProvider errorProvider1;
		private ErrorProvider errorProvider2;
	}
}