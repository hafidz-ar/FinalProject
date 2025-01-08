namespace ManajemenProperti.View
{
    partial class FormTambahProperti
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtHargaSewa = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelHargaSewa = new System.Windows.Forms.Label();
            this.labelStok = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtNama
            this.txtNama.Location = new System.Drawing.Point(20, 40);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 20);
            this.txtNama.TabIndex = 0;

            // txtStok
            this.txtStok.Location = new System.Drawing.Point(20, 120);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(250, 20);
            this.txtStok.TabIndex = 2;

            // txtHargaSewa
            this.txtHargaSewa.Location = new System.Drawing.Point(20, 80);
            this.txtHargaSewa.Name = "txtHargaSewa";
            this.txtHargaSewa.Size = new System.Drawing.Size(250, 20);
            this.txtHargaSewa.TabIndex = 1;

            // btnSimpan
            this.btnSimpan.Location = new System.Drawing.Point(100, 160);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            // labelNama
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(20, 20);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 4;
            this.labelNama.Text = "Nama";

            // labelHargaSewa
            this.labelHargaSewa.AutoSize = true;
            this.labelHargaSewa.Location = new System.Drawing.Point(20, 60);
            this.labelHargaSewa.Name = "labelHargaSewa";
            this.labelHargaSewa.Size = new System.Drawing.Size(68, 13);
            this.labelHargaSewa.TabIndex = 5;
            this.labelHargaSewa.Text = "Harga Sewa";

            // labelStok
            this.labelStok.AutoSize = true;
            this.labelStok.Location = new System.Drawing.Point(20, 100);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(29, 13);
            this.labelStok.TabIndex = 6;
            this.labelStok.Text = "Stok";

            // FormTambahProperti
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.labelStok);
            this.Controls.Add(this.labelHargaSewa);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHargaSewa);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTambahProperti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Properti";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtHargaSewa;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelHargaSewa;
        private System.Windows.Forms.Label labelStok;
    }
}
