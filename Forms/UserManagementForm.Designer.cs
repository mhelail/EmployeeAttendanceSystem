namespace CalisanTakipAdvanced.Forms
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private DataGridView dgvUsers;

        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;

        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;

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
            this.dgvUsers = new System.Windows.Forms.DataGridView();

            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // 
            // UserManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönet";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.Load += new System.EventHandler(this.UserManagementForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Kullanıcı Yönet";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.AutoSize = true;

            // 
            // dgvUsers
            // 
            this.dgvUsers.Location = new System.Drawing.Point(20, 60);
            this.dgvUsers.Size = new System.Drawing.Size(400, 300);
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);

            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Kullanıcı Adı:";
            this.lblUsername.Location = new System.Drawing.Point(450, 60);
            this.lblUsername.AutoSize = true;

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(450, 80);
            this.txtUsername.Size = new System.Drawing.Size(220, 23);

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Şifre:";
            this.lblPassword.Location = new System.Drawing.Point(450, 115);
            this.lblPassword.AutoSize = true;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(450, 135);
            this.txtPassword.Size = new System.Drawing.Size(220, 23);

            // 
            // lblRole
            // 
            this.lblRole.Text = "Rol:";
            this.lblRole.Location = new System.Drawing.Point(450, 170);
            this.lblRole.AutoSize = true;

            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(450, 190);
            this.cmbRole.Size = new System.Drawing.Size(220, 23);

            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Location = new System.Drawing.Point(450, 240);
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
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.Location = new System.Drawing.Point(580, 240);
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
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Location = new System.Drawing.Point(450, 290);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // Add Controls
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvUsers);

            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
