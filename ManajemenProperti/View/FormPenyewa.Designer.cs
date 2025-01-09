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
            this.lvwFormPenyewa = new System.Windows.Forms.ListView();
            this.btnTambahPrp = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnSewaPrp = new System.Windows.Forms.Button();
            this.btnRiwayatTrx = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Default font and styles
            System.Drawing.Font defaultFont = new System.Drawing.Font("Segoe UI", 10F);

            // lvwFormPenyewa
            this.lvwFormPenyewa.Font = defaultFont;
            this.lvwFormPenyewa.HideSelection = false;
            this.lvwFormPenyewa.Location = new System.Drawing.Point(12, 80);
            this.lvwFormPenyewa.Name = "lvwFormPenyewa";
            this.lvwFormPenyewa.Size = new System.Drawing.Size(574, 420);
            this.lvwFormPenyewa.TabIndex = 12;
            this.lvwFormPenyewa.UseCompatibleStateImageBehavior = false;

            // btnTambahPrp
            this.btnTambahPrp.Font = defaultFont;
            this.btnTambahPrp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahPrp.ForeColor = System.Drawing.Color.White;
            this.btnTambahPrp.Location = new System.Drawing.Point(421, 25);
            this.btnTambahPrp.Name = "btnTambahPrp";
            this.btnTambahPrp.Size = new System.Drawing.Size(165, 40);
            this.btnTambahPrp.TabIndex = 8;
            this.btnTambahPrp.Text = "Tambah Properti";
            this.btnTambahPrp.UseVisualStyleBackColor = false;
            this.btnTambahPrp.Click += new System.EventHandler(this.btnTambahPrp_Click);

            // searchField
            this.searchField.Font = defaultFont;
            this.searchField.Location = new System.Drawing.Point(12, 30);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(330, 25);
            this.searchField.TabIndex = 13;

            // btnCari
            this.btnCari.Font = defaultFont;
            this.btnCari.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(348, 25);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(67, 40);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);

            // btnSewaPrp
            this.btnSewaPrp.Font = defaultFont;
            this.btnSewaPrp.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSewaPrp.ForeColor = System.Drawing.Color.White;
            this.btnSewaPrp.Location = new System.Drawing.Point(12, 520);
            this.btnSewaPrp.Name = "btnSewaPrp";
            this.btnSewaPrp.Size = new System.Drawing.Size(165, 40);
            this.btnSewaPrp.TabIndex = 15;
            this.btnSewaPrp.Text = "Sewa Properti";
            this.btnSewaPrp.UseVisualStyleBackColor = false;
            this.btnSewaPrp.Click += new System.EventHandler(this.btnSewaPrp_Click);

            // btnRiwayatTrx
            this.btnRiwayatTrx.Font = defaultFont;
            this.btnRiwayatTrx.BackColor = System.Drawing.Color.IndianRed;
            this.btnRiwayatTrx.ForeColor = System.Drawing.Color.White;
            this.btnRiwayatTrx.Location = new System.Drawing.Point(183, 520);
            this.btnRiwayatTrx.Name = "btnRiwayatTrx";
            this.btnRiwayatTrx.Size = new System.Drawing.Size(165, 40);
            this.btnRiwayatTrx.TabIndex = 16;
            this.btnRiwayatTrx.Text = "Riwayat Transaksi";
            this.btnRiwayatTrx.UseVisualStyleBackColor = false;
            this.btnRiwayatTrx.Click += new System.EventHandler(this.btnRiwayatTrx_Click);

            // FormPenyewa
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 588);
            this.Controls.Add(this.btnRiwayatTrx);
            this.Controls.Add(this.btnSewaPrp);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.lvwFormPenyewa);
            this.Controls.Add(this.btnTambahPrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPenyewa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penyewa";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
