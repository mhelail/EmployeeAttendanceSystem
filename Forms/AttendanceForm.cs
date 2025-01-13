using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalisanTakipAdvanced.Forms
{
    public partial class AttendanceForm : Form
    {
        private AttendanceDAL attendanceDAL = new AttendanceDAL();
        private EmployeeDAL employeeDAL = new EmployeeDAL();
        private User currentUser;

        public AttendanceForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            // Çalışan listesini yükle
            List<Employee> employees = employeeDAL.GetAllEmployees();
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "EmployeeID";

            cmbStatus.Items.AddRange(new string[] { "Present", "Absent", "Late" });
            cmbStatus.SelectedIndex = 0; // Varsayılan olarak ilkini seç

            LoadAttendanceGrid();
        }

        private void LoadAttendanceGrid()
        {
            List<AttendanceRecord> records = attendanceDAL.GetAllAttendance();
            dgvAttendance.DataSource = records;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedItem is Employee emp && cmbStatus.SelectedItem != null)
            {
                AttendanceRecord record = new AttendanceRecord
                {
                    EmployeeID = emp.EmployeeID,
                    Date = dtpDate.Value.Date,
                    CheckInTime = chkCheckIn.Checked ? dtpCheckIn.Value.TimeOfDay : (TimeSpan?)null,
                    CheckOutTime = chkCheckOut.Checked ? dtpCheckOut.Value.TimeOfDay : (TimeSpan?)null,
                    Status = cmbStatus.SelectedItem.ToString()
                };

                bool success = attendanceDAL.AddAttendance(record);
                if (success)
                {
                    MessageBox.Show("Devamsızlık kaydı eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAttendanceGrid();
                }
                else
                {
                    MessageBox.Show("Kayıt eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null) return;
            AttendanceRecord rec = (AttendanceRecord)dgvAttendance.CurrentRow.DataBoundItem;
            if (rec == null) return;

            if (cmbEmployee.SelectedItem is Employee emp && cmbStatus.SelectedItem != null)
            {
                rec.EmployeeID = emp.EmployeeID;
                rec.Date = dtpDate.Value.Date;
                rec.CheckInTime = chkCheckIn.Checked ? dtpCheckIn.Value.TimeOfDay : (TimeSpan?)null;
                rec.CheckOutTime = chkCheckOut.Checked ? dtpCheckOut.Value.TimeOfDay : (TimeSpan?)null;
                rec.Status = cmbStatus.SelectedItem.ToString();

                bool success = attendanceDAL.UpdateAttendance(rec);
                if (success)
                {
                    MessageBox.Show("Devamsızlık kaydı güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAttendanceGrid();
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null) return;
            AttendanceRecord rec = (AttendanceRecord)dgvAttendance.CurrentRow.DataBoundItem;
            if (rec == null) return;

            DialogResult dr = MessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Onay",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool success = attendanceDAL.DeleteAttendance(rec.AttendanceID);
                if (success)
                {
                    MessageBox.Show("Devamsızlık kaydı silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAttendanceGrid();
                }
                else
                {
                    MessageBox.Show("Silme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AttendanceRecord selected = (AttendanceRecord)dgvAttendance.Rows[e.RowIndex].DataBoundItem;
                if (selected != null)
                {
                    // Çalışan drop-down'ı
                    cmbEmployee.SelectedValue = selected.EmployeeID;
                    dtpDate.Value = selected.Date;
                    chkCheckIn.Checked = selected.CheckInTime.HasValue;
                    if (selected.CheckInTime.HasValue)
                        dtpCheckIn.Value = DateTime.Today.Add(selected.CheckInTime.Value);
                    chkCheckOut.Checked = selected.CheckOutTime.HasValue;
                    if (selected.CheckOutTime.HasValue)
                        dtpCheckOut.Value = DateTime.Today.Add(selected.CheckOutTime.Value);
                    cmbStatus.SelectedItem = selected.Status;
                }
            }
        }
    }
}
