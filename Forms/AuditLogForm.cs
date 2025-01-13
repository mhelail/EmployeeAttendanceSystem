using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalisanTakipAdvanced.Forms
{
    public partial class AuditLogForm : Form
    {
        private AuditLogDAL auditLogDAL = new AuditLogDAL();

        public AuditLogForm()
        {
            InitializeComponent();
        }

        private void AuditLogForm_Load(object sender, EventArgs e)
        {
            List<AuditLog> logs = auditLogDAL.GetAllLogs();
            dgvLogs.DataSource = logs;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Yeniden yükle
            List<AuditLog> logs = auditLogDAL.GetAllLogs();
            dgvLogs.DataSource = logs;
        }
    }
}
