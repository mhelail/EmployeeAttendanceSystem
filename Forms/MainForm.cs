using CalisanTakipAdvanced.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalisanTakipAdvanced.Forms
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // "Hoş geldiniz ..." ifadesini yerleştiriyoruz:
            lblGreeting.Text = $"Hoş geldiniz, {currentUser.Username} ({currentUser.Role})";

            // Örnek: Eğer kullanıcı "Employee" rolündeyse bazı butonları kapatabilirsiniz:
            if (currentUser.Role == "Employee")
            {
                btnKullaniciYonet.Enabled = false;
            }
        }

        private void btnCalisanlariYonet_Click(object sender, EventArgs e)
        {
            // Çalışan yönetimi formu
            EmployeeForm empForm = new EmployeeForm(currentUser);
            empForm.ShowDialog();
        }

        private void btnDevamsizlik_Click(object sender, EventArgs e)
        {
            // Devamsızlık formu
            AttendanceForm attForm = new AttendanceForm(currentUser);
            attForm.ShowDialog();
        }

        private void btnLogKayitlari_Click(object sender, EventArgs e)
        {
            // Denetim kayıtları formu
            AuditLogForm logForm = new AuditLogForm();
            logForm.ShowDialog();
        }

        private void btnKullaniciYonet_Click(object sender, EventArgs e)
        {
            // Kullanıcı yönetimi formu (opsiyonel)
            UserManagementForm userForm = new UserManagementForm();
            userForm.ShowDialog();
        }
    }
}
