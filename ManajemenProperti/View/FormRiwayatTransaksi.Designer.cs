namespace ManajemenProperti.View
{
    partial class FormRiwayatTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwRiwayatTransaksi = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwRiwayatTransaksi
            // 
            this.lvwRiwayatTransaksi.HideSelection = false;
            this.lvwRiwayatTransaksi.Location = new System.Drawing.Point(12, 80);
            this.lvwRiwayatTransaksi.Name = "lvwRiwayatTransaksi";
            this.lvwRiwayatTransaksi.Size = new System.Drawing.Size(754, 428);
            this.lvwRiwayatTransaksi.TabIndex = 13;
            this.lvwRiwayatTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Riwayat Transaksi";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(601, 529);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(165, 37);
            this.btnKembali.TabIndex = 17;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // FormRiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 588);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwRiwayatTransaksi);
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
    }
}