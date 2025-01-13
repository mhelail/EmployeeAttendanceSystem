namespace CalisanTakipAdvanced.Forms
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private DataGridView dgvEmployees;

        // Fields for employee data entry
        private Label lblName;
        private Label lblPosition;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblHireDate;

        private TextBox txtName;
        private TextBox txtPosition;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private DateTimePicker dtpHireDate;

        // Buttons
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();

            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();

            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışanları Yönet";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);

            //
            // lblTitle
            //
            this.lblTitle.Text = "Çalışanları Yönet";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);

            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Location = new System.Drawing.Point(20, 60);
            this.dgvEmployees.Size = new System.Drawing.Size(500, 300);
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);

            // 
            // lblName
            // 
            this.lblName.Text = "Ad-Soyad:";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(550, 60);
            this.lblName.AutoSize = true;

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(550, 80);
            this.txtName.Size = new System.Drawing.Size(220, 25);
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // lblPosition
            // 
            this.lblPosition.Text = "Pozisyon:";
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblPosition.Location = new System.Drawing.Point(550, 115);
            this.lblPosition.AutoSize = true;

            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(550, 135);
            this.txtPosition.Size = new System.Drawing.Size(220, 25);
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // lblPhone
            // 
            this.lblPhone.Text = "Telefon:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblPhone.Location = new System.Drawing.Point(550, 170);
            this.lblPhone.AutoSize = true;

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(550, 190);
            this.txtPhone.Size = new System.Drawing.Size(220, 25);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // lblEmail
            // 
            this.lblEmail.Text = "E-posta:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblEmail.Location = new System.Drawing.Point(550, 225);
            this.lblEmail.AutoSize = true;

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(550, 245);
            this.txtEmail.Size = new System.Drawing.Size(220, 25);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // lblAddress
            // 
            this.lblAddress.Text = "Adres:";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblAddress.Location = new System.Drawing.Point(550, 280);
            this.lblAddress.AutoSize = true;

            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(550, 300);
            this.txtAddress.Size = new System.Drawing.Size(220, 25);
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10);

            // 
            // lblHireDate
            // 
            this.lblHireDate.Text = "İşe Başlama Tarihi:";
            this.lblHireDate.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblHireDate.Location = new System.Drawing.Point(550, 335);
            this.lblHireDate.AutoSize = true;

            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(550, 355);
            this.dtpHireDate.Size = new System.Drawing.Size(220, 25);
            this.dtpHireDate.Font = new System.Drawing.Font("Segoe UI", 10);
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Çalışan Ekle";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.Location = new System.Drawing.Point(50, 400);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "Çalışan Güncelle";
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Size = new System.Drawing.Size(180, 40);
            this.btnUpdate.Location = new System.Drawing.Point(250, 400);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Text = "Çalışan Sil";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Size = new System.Drawing.Size(180, 40);
            this.btnDelete.Location = new System.Drawing.Point(450, 400);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // Add Controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvEmployees);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.dtpHireDate);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
