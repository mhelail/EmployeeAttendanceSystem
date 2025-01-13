using System;
using System.Windows.Forms;
using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;

namespace CalisanTakipAdvanced.Forms
{
    public partial class LoginForm : Form
    {
        private UserDAL userDAL = new UserDAL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kullanıcı doğrulama
            User user = userDAL.ValidateUser(username, password);
            if (user == null)
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Giriş başarılıysa ana formu açalım
            MainForm mainForm = new MainForm(user);
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
