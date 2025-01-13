namespace CalisanTakipAdvanced.Forms
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private DataGridView dgvAttendance;

        private Label lblEmployee;
        private ComboBox cmbEmployee;

        private Label lblDate;
        private DateTimePicker dtpDate;

        private Label lblCheckIn;
        private DateTimePicker dtpCheckIn;
        private CheckBox chkCheckIn;

        private Label lblCheckOut;
        private DateTimePicker dtpCheckOut;
        private CheckBox chkCheckOut;

        private Label lblStatus;
        private ComboBox cmbStatus;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();

            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();

            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();

            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.chkCheckIn = new System.Windows.Forms.CheckBox();

            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();

            // 
            // AttendanceForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devamsızlık Yönetimi";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.Load += new System.EventHandler(this.AttendanceForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Devamsızlık Yönetimi";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.AutoSize = true;

            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Location = new System.Drawing.Point(20, 60);
            this.dgvAttendance.Size = new System.Drawing.Size(460, 300);
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellClick);

            // 
            // lblEmployee
            // 
            this.lblEmployee.Text = "Çalışan:";
            this.lblEmployee.Location = new System.Drawing.Point(500, 60);
            this.lblEmployee.AutoSize = true;

            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Location = new System.Drawing.Point(500, 80);
            this.cmbEmployee.Size = new System.Drawing.Size(250, 23);

            // 
            // lblDate
            // 
            this.lblDate.Text = "Tarih:";
            this.lblDate.Location = new System.Drawing.Point(500, 115);
            this.lblDate.AutoSize = true;

            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(500, 135);
            this.dtpDate.Size = new System.Drawing.Size(250, 23);

            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Text = "Giriş Saati:";
            this.lblCheckIn.Location = new System.Drawing.Point(500, 170);
            this.lblCheckIn.AutoSize = true;

            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckIn.Location = new System.Drawing.Point(500, 190);
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 23);

            // 
            // chkCheckIn
            // 
            this.chkCheckIn.Text = "Belirle";
            this.chkCheckIn.Location = new System.Drawing.Point(710, 190);
            this.chkCheckIn.Size = new System.Drawing.Size(60, 23);

            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Text = "Çıkış Saati:";
            this.lblCheckOut.Location = new System.Drawing.Point(500, 225);
            this.lblCheckOut.AutoSize = true;

            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckOut.Location = new System.Drawing.Point(500, 245);
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 23);

            // 
            // chkCheckOut
            // 
            this.chkCheckOut.Text = "Belirle";
            this.chkCheckOut.Location = new System.Drawing.Point(710, 245);
            this.chkCheckOut.Size = new System.Drawing.Size(60, 23);

            // 
            // lblStatus
            // 
            this.lblStatus.Text = "Durum:";
            this.lblStatus.Location = new System.Drawing.Point(500, 280);
            this.lblStatus.AutoSize = true;

            // 
            // cmbStatus
            // 
            this.cmbStatus.Location = new System.Drawing.Point(500, 300);
            this.cmbStatus.Size = new System.Drawing.Size(250, 23);

            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.Location = new System.Drawing.Point(500, 350);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.Location = new System.Drawing.Point(590, 350);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Text = "Sil";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.Location = new System.Drawing.Point(680, 350);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // Add Controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAttendance);

            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbEmployee);

            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);

            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.chkCheckIn);

            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.chkCheckOut);

            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
