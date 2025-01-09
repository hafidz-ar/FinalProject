namespace ManajemenProperti.View
{
    partial class FormRiwayatTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayatTransaksi));
            this.lvwRiwayatTransaksi = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwRiwayatTransaksi
            // 
            this.lvwRiwayatTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvwRiwayatTransaksi.HideSelection = false;
            this.lvwRiwayatTransaksi.Location = new System.Drawing.Point(8, 39);
            this.lvwRiwayatTransaksi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwRiwayatTransaksi.Name = "lvwRiwayatTransaksi";
            this.lvwRiwayatTransaksi.Size = new System.Drawing.Size(504, 294);
            this.lvwRiwayatTransaksi.TabIndex = 13;
            this.lvwRiwayatTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Riwayat Transaksi";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(401, 338);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(110, 26);
            this.btnKembali.TabIndex = 17;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.IndianRed;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(287, 338);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 26);
            this.btnHapus.TabIndex = 18;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FormRiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(519, 382);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwRiwayatTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRiwayatTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riwayat Transaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvwRiwayatTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnHapus;
    }
}
