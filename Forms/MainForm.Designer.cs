namespace CalisanTakipAdvanced.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblGreeting;        // <-- New label for “Hoş geldiniz” text
        private Button btnCalisanlariYonet;
        private Button btnDevamsizlik;
        private Button btnLogKayitlari;
        private Button btnKullaniciYonet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();  // <-- Create the label
            this.btnCalisanlariYonet = new System.Windows.Forms.Button();
            this.btnDevamsizlik = new System.Windows.Forms.Button();
            this.btnLogKayitlari = new System.Windows.Forms.Button();
            this.btnKullaniciYonet = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Çalışanlar Takip Sistemi";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.Load += new System.EventHandler(this.MainForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Çalışanlar Takip Sistemi";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point((this.ClientSize.Width - 300) / 2, 20);

            // 
            // lblGreeting
            // 
            this.lblGreeting.Text = "Hoş geldiniz, admin (Admin)";
            // Farklı font stili: italic & orta boy
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.ForeColor = System.Drawing.Color.DimGray;
            this.lblGreeting.AutoSize = true;
            // Konumu: main title’ın biraz altı
            this.lblGreeting.Location = new System.Drawing.Point((this.ClientSize.Width - 300) / 2, 60);

            // 
            // btnCalisanlariYonet
            // 
            this.btnCalisanlariYonet.Text = "Çalışanları Yönet";
            this.btnCalisanlariYonet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalisanlariYonet.ForeColor = System.Drawing.Color.White;
            this.btnCalisanlariYonet.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCalisanlariYonet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanlariYonet.FlatAppearance.BorderSize = 0;
            this.btnCalisanlariYonet.Size = new System.Drawing.Size(250, 50);
            this.btnCalisanlariYonet.Location = new System.Drawing.Point((this.ClientSize.Width - 250) / 2, 110);
            this.btnCalisanlariYonet.Click += new System.EventHandler(this.btnCalisanlariYonet_Click);

            // 
            // btnDevamsizlik
            // 
            this.btnDevamsizlik.Text = "Devamsızlık Yönetimi";
            this.btnDevamsizlik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDevamsizlik.ForeColor = System.Drawing.Color.White;
            this.btnDevamsizlik.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnDevamsizlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevamsizlik.FlatAppearance.BorderSize = 0;
            this.btnDevamsizlik.Size = new System.Drawing.Size(250, 50);
            this.btnDevamsizlik.Location = new System.Drawing.Point((this.ClientSize.Width - 250) / 2, 180);
            this.btnDevamsizlik.Click += new System.EventHandler(this.btnDevamsizlik_Click);

            // 
            // btnLogKayitlari
            // 
            this.btnLogKayitlari.Text = "Kayıtları Görüntüle";
            this.btnLogKayitlari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogKayitlari.ForeColor = System.Drawing.Color.White;
            this.btnLogKayitlari.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogKayitlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogKayitlari.FlatAppearance.BorderSize = 0;
            this.btnLogKayitlari.Size = new System.Drawing.Size(250, 50);
            this.btnLogKayitlari.Location = new System.Drawing.Point((this.ClientSize.Width - 250) / 2, 250);
            this.btnLogKayitlari.Click += new System.EventHandler(this.btnLogKayitlari_Click);

            // 
            // btnKullaniciYonet
            // 
            this.btnKullaniciYonet.Text = "Kullanıcı Yönet";
            this.btnKullaniciYonet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKullaniciYonet.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciYonet.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnKullaniciYonet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciYonet.FlatAppearance.BorderSize = 0;
            this.btnKullaniciYonet.Size = new System.Drawing.Size(250, 40);
            this.btnKullaniciYonet.Location = new System.Drawing.Point((this.ClientSize.Width - 250) / 2, 320);
            this.btnKullaniciYonet.Click += new System.EventHandler(this.btnKullaniciYonet_Click);

            // 
            // Add controls to the form
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnCalisanlariYonet);
            this.Controls.Add(this.btnDevamsizlik);
            this.Controls.Add(this.btnLogKayitlari);
            this.Controls.Add(this.btnKullaniciYonet);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
