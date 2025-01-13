using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalisanTakipAdvanced.Forms
{
    public partial class UserManagementForm : Form
    {
        private UserDAL userDAL = new UserDAL();

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            cmbRole.Items.AddRange(new string[] { "Admin", "Employee" });
        }

        private void LoadUsers()
        {
            List<User> users = userDAL.GetAllUsers();
            dgvUsers.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User u = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = cmbRole.SelectedItem?.ToString()
            };

            bool success = userDAL.AddUser(u);
            if (success)
            {
                MessageBox.Show("Kullanıcı eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Kullanıcı eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            User selected = (User)dgvUsers.CurrentRow.DataBoundItem;
            if (selected == null) return;

            selected.Username = txtUsername.Text;
            selected.Password = txtPassword.Text;
            selected.Role = cmbRole.SelectedItem?.ToString();

            bool success = userDAL.UpdateUser(selected);
            if (success)
            {
                MessageBox.Show("Kullanıcı güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            User selected = (User)dgvUsers.CurrentRow.DataBoundItem;
            if (selected == null) return;

            DialogResult dr = MessageBox.Show("Seçili kullanıcıyı silmek istiyor musunuz?",
                                              "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool success = userDAL.DeleteUser(selected.UserID);
                if (success)
                {
                    MessageBox.Show("Kullanıcı silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Silme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                User selected = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;
                if (selected != null)
                {
                    txtUsername.Text = selected.Username;
                    txtPassword.Text = selected.Password;
                    cmbRole.SelectedItem = selected.Role;
                }
            }
        }
    }
}
