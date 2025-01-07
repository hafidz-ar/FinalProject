namespace ManajemenProperti.View
{
    partial class FormPenyewa
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
            this.lvwFormPenyewa = new System.Windows.Forms.ListView();
            this.btnTambahPrp = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwFormPenyewa
            // 
            this.lvwFormPenyewa.HideSelection = false;
            this.lvwFormPenyewa.Location = new System.Drawing.Point(12, 80);
            this.lvwFormPenyewa.Name = "lvwFormPenyewa";
            this.lvwFormPenyewa.Size = new System.Drawing.Size(574, 428);
            this.lvwFormPenyewa.TabIndex = 12;
            this.lvwFormPenyewa.UseCompatibleStateImageBehavior = false;
            this.lvwFormPenyewa.SelectedIndexChanged += new System.EventHandler(this.lvwFormPenyewa_SelectedIndexChanged);
            // 
            // btnTambahPrp
            // 
            this.btnTambahPrp.Location = new System.Drawing.Point(421, 25);
            this.btnTambahPrp.Name = "btnTambahPrp";
            this.btnTambahPrp.Size = new System.Drawing.Size(165, 37);
            this.btnTambahPrp.TabIndex = 8;
            this.btnTambahPrp.Text = "Tambah Properti";
            this.btnTambahPrp.UseVisualStyleBackColor = true;
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(12, 30);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(329, 26);
            this.searchField.TabIndex = 13;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(348, 25);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(68, 37);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tambah Properti";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.lvwFormPenyewa);
            this.Controls.Add(this.btnTambahPrp);
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
        private System.Windows.Forms.Button button1;
    }
}