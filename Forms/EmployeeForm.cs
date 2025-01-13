using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalisanTakipAdvanced.Forms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeDAL employeeDAL = new EmployeeDAL();
        private AuditLogDAL auditLogDAL = new AuditLogDAL(); // if you want to log changes
        private User currentUser;

        public EmployeeForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeGrid();
        }

        private void LoadEmployeeGrid()
        {
            List<Employee> employees = employeeDAL.GetAllEmployees();
            dgvEmployees.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = txtName.Text,
                Position = txtPosition.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                HireDate = dtpHireDate.Value
            };

            bool success = employeeDAL.AddEmployee(emp);
            if (success)
            {
                MessageBox.Show("Çalışan başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally log
                // auditLogDAL.InsertLog(currentUser.UserID, "Yeni çalışan eklendi: " + emp.Name);
                LoadEmployeeGrid();
            }
            else
            {
                MessageBox.Show("Çalışan eklenirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            Employee selectedEmp = (Employee)dgvEmployees.CurrentRow.DataBoundItem;

            selectedEmp.Name = txtName.Text;
            selectedEmp.Position = txtPosition.Text;
            selectedEmp.Phone = txtPhone.Text;
            selectedEmp.Email = txtEmail.Text;
            selectedEmp.Address = txtAddress.Text;
            selectedEmp.HireDate = dtpHireDate.Value;

            bool success = employeeDAL.UpdateEmployee(selectedEmp);
            if (success)
            {
                MessageBox.Show("Çalışan güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // auditLogDAL.InsertLog(currentUser.UserID, "Çalışan güncellendi: " + selectedEmp.Name);
                LoadEmployeeGrid();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            Employee selectedEmp = (Employee)dgvEmployees.CurrentRow.DataBoundItem;

            DialogResult dr = MessageBox.Show("Seçili çalışanı silmek istiyor musunuz?", "Onay",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool success = employeeDAL.DeleteEmployee(selectedEmp.EmployeeID);
                if (success)
                {
                    MessageBox.Show("Çalışan silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // auditLogDAL.InsertLog(currentUser.UserID, "Çalışan silindi: " + selectedEmp.Name);
                    LoadEmployeeGrid();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Employee selectedEmp = (Employee)dgvEmployees.Rows[e.RowIndex].DataBoundItem;
                txtName.Text = selectedEmp.Name;
                txtPosition.Text = selectedEmp.Position;
                txtPhone.Text = selectedEmp.Phone;
                txtEmail.Text = selectedEmp.Email;
                txtAddress.Text = selectedEmp.Address;
                dtpHireDate.Value = selectedEmp.HireDate;
            }
        }
    }
}
