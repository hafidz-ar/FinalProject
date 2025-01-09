namespace ManajemenProperti.View
{
    partial class FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            this.dtpTglSewa = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLamaSewa = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLamaSewa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTglSewa
            // 
            this.dtpTglSewa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTglSewa.Location = new System.Drawing.Point(35, 52);
            this.dtpTglSewa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTglSewa.Name = "dtpTglSewa";
            this.dtpTglSewa.Size = new System.Drawing.Size(250, 25);
            this.dtpTglSewa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal Sewa";
            // 
            // nudLamaSewa
            // 
            this.nudLamaSewa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudLamaSewa.Location = new System.Drawing.Point(35, 117);
            this.nudLamaSewa.Margin = new System.Windows.Forms.Padding(2);
            this.nudLamaSewa.Name = "nudLamaSewa";
            this.nudLamaSewa.Size = new System.Drawing.Size(250, 25);
            this.nudLamaSewa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lama Sewa";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(95, 171);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 35);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLamaSewa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTglSewa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.nudLamaSewa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTglSewa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLamaSewa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
    }
}
