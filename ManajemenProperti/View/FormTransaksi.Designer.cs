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
            this.dtpTglSewa.Location = new System.Drawing.Point(53, 80);
            this.dtpTglSewa.Name = "dtpTglSewa";
            this.dtpTglSewa.Size = new System.Drawing.Size(273, 26);
            this.dtpTglSewa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lama Sewa";
            // 
            // nudLamaSewa
            // 
            this.nudLamaSewa.Location = new System.Drawing.Point(53, 180);
            this.nudLamaSewa.Name = "nudLamaSewa";
            this.nudLamaSewa.Size = new System.Drawing.Size(273, 26);
            this.nudLamaSewa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal Sewa";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(161, 263);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(165, 37);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 348);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLamaSewa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTglSewa);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
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