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
            this.dtpTglSewa.Location = new System.Drawing.Point(35, 52);
            this.dtpTglSewa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTglSewa.Name = "dtpTglSewa";
            this.dtpTglSewa.Size = new System.Drawing.Size(183, 20);
            this.dtpTglSewa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal Sewa";
            // 
            // nudLamaSewa
            // 
            this.nudLamaSewa.Location = new System.Drawing.Point(35, 117);
            this.nudLamaSewa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudLamaSewa.Name = "nudLamaSewa";
            this.nudLamaSewa.Size = new System.Drawing.Size(182, 20);
            this.nudLamaSewa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lama Sewa";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(107, 171);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 24);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 226);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLamaSewa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTglSewa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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