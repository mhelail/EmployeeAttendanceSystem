namespace CalisanTakipAdvanced.Forms
{
    partial class AuditLogForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private DataGridView dgvLogs;
        private Button btnRefresh;
        private Button btnClose; // opsiyonel

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();

            // 
            // AuditLogForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıtları Görüntüle";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.Load += new System.EventHandler(this.AuditLogForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Kayıtları Görüntüle";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.AutoSize = true;

            // 
            // dgvLogs
            // 
            this.dgvLogs.Location = new System.Drawing.Point(20, 60);
            this.dgvLogs.Size = new System.Drawing.Size(560, 250);
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.Location = new System.Drawing.Point(20, 320);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // btnClose
            // 
            this.btnClose.Text = "Kapat";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.Location = new System.Drawing.Point(160, 320);
            this.btnClose.Click += (s, e) => this.Close(); // Lambda, formu kapat

            // 
            // Add Controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
