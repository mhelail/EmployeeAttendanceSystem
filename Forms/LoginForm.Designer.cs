using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalisanTakipAdvanced.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlContainer;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlContainer = new Panel();
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();

            // 
            // LoginForm
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Giriş Yap";

            // Arka plan rengi
            this.BackColor = Color.FromArgb(236, 240, 241);

            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = Color.White;
            this.pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            this.pnlContainer.Location = new Point(50, 50);
            this.pnlContainer.Size = new Size(350, 250);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Kullanıcı Girişi";
            // Daha büyük font + kalın
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(85, 20);
            // Adjust konum if needed for perfect centering

            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Kullanıcı Adı:";
            this.lblUsername.Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point);
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new Point(30, 70);

            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point);
            this.txtUsername.Location = new Point(30, 90);
            this.txtUsername.Size = new Size(280, 25);
            // .NET 6+ için (isteğe bağlı):
            // this.txtUsername.PlaceholderText = "Kullanıcı Adı";

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Şifre:";
            this.lblPassword.Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point);
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(30, 130);

            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPassword.Location = new Point(30, 150);
            this.txtPassword.Size = new Size(280, 25);
            this.txtPassword.UseSystemPasswordChar = true;
            // .NET 6+ için (isteğe bağlı):
            // this.txtPassword.PlaceholderText = "Şifre";

            // 
            // btnLogin
            // 
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Font = new Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Point);
            this.btnLogin.BackColor = Color.FromArgb(46, 204, 113); // Yeşil
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Size = new Size(280, 40);
            this.btnLogin.Location = new Point(30, 190);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // Panel içine ekle
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.lblUsername);
            this.pnlContainer.Controls.Add(this.txtUsername);
            this.pnlContainer.Controls.Add(this.lblPassword);
            this.pnlContainer.Controls.Add(this.txtPassword);
            this.pnlContainer.Controls.Add(this.btnLogin);

            // Ana formun kontrollerine paneli ekle
            this.Controls.Add(this.pnlContainer);
        }
    }
}
