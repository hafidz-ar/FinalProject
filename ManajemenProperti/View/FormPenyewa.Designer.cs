namespace ManajemenProperti.View
{
    partial class FormPenyewa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenyewa));
            this.lvwFormPenyewa = new System.Windows.Forms.ListView();
            this.btnTambahPrp = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnSewaPrp = new System.Windows.Forms.Button();
            this.btnRiwayatTrx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwFormPenyewa
            // 
            this.lvwFormPenyewa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvwFormPenyewa.HideSelection = false;
            this.lvwFormPenyewa.Location = new System.Drawing.Point(8, 52);
            this.lvwFormPenyewa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwFormPenyewa.Name = "lvwFormPenyewa";
            this.lvwFormPenyewa.Size = new System.Drawing.Size(384, 274);
            this.lvwFormPenyewa.TabIndex = 12;
            this.lvwFormPenyewa.UseCompatibleStateImageBehavior = false;
            // 
            // btnTambahPrp
            // 
            this.btnTambahPrp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahPrp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTambahPrp.ForeColor = System.Drawing.Color.White;
            this.btnTambahPrp.Location = new System.Drawing.Point(281, 16);
            this.btnTambahPrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTambahPrp.Name = "btnTambahPrp";
            this.btnTambahPrp.Size = new System.Drawing.Size(110, 26);
            this.btnTambahPrp.TabIndex = 8;
            this.btnTambahPrp.Text = "Tambah Properti";
            this.btnTambahPrp.UseVisualStyleBackColor = false;
            this.btnTambahPrp.Click += new System.EventHandler(this.btnTambahPrp_Click);
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchField.Location = new System.Drawing.Point(8, 20);
            this.searchField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(221, 25);
            this.searchField.TabIndex = 13;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(232, 16);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(45, 26);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnSewaPrp
            // 
            this.btnSewaPrp.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSewaPrp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSewaPrp.ForeColor = System.Drawing.Color.White;
            this.btnSewaPrp.Location = new System.Drawing.Point(8, 338);
            this.btnSewaPrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSewaPrp.Name = "btnSewaPrp";
            this.btnSewaPrp.Size = new System.Drawing.Size(110, 26);
            this.btnSewaPrp.TabIndex = 15;
            this.btnSewaPrp.Text = "Sewa Properti";
            this.btnSewaPrp.UseVisualStyleBackColor = false;
            this.btnSewaPrp.Click += new System.EventHandler(this.btnSewaPrp_Click);
            // 
            // btnRiwayatTrx
            // 
            this.btnRiwayatTrx.BackColor = System.Drawing.Color.IndianRed;
            this.btnRiwayatTrx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRiwayatTrx.ForeColor = System.Drawing.Color.White;
            this.btnRiwayatTrx.Location = new System.Drawing.Point(122, 338);
            this.btnRiwayatTrx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRiwayatTrx.Name = "btnRiwayatTrx";
            this.btnRiwayatTrx.Size = new System.Drawing.Size(110, 26);
            this.btnRiwayatTrx.TabIndex = 16;
            this.btnRiwayatTrx.Text = "Riwayat Transaksi";
            this.btnRiwayatTrx.UseVisualStyleBackColor = false;
            this.btnRiwayatTrx.Click += new System.EventHandler(this.btnRiwayatTrx_Click);
            // 
            // FormPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 382);
            this.Controls.Add(this.btnRiwayatTrx);
            this.Controls.Add(this.btnSewaPrp);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.lvwFormPenyewa);
            this.Controls.Add(this.btnTambahPrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPenyewa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penyewa";
            this.Load += new System.EventHandler(this.FormPenyewa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambahPrp;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button btnCari;
        public System.Windows.Forms.ListView lvwFormPenyewa;
        private System.Windows.Forms.Button btnSewaPrp;
        private System.Windows.Forms.Button btnRiwayatTrx;
    }
}
