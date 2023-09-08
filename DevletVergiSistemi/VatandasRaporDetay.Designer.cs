namespace DevletVergiSistemi
{
    partial class VatandasRaporDetay
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
            this.btn_adresSorgu = new System.Windows.Forms.Button();
            this.btn_meslekSorgu = new System.Windows.Forms.Button();
            this.txt_sehirSorgu = new System.Windows.Forms.TextBox();
            this.txt_meslekSorgu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_vatandasRaporDetay = new System.Windows.Forms.DataGridView();
            this.btn_tcBaslangiciDokuz = new System.Windows.Forms.Button();
            this.btn_meslekBorcDurumBakanlikAd = new System.Windows.Forms.Button();
            this.btn_kisiNoTcAdresBorcAdTutar = new System.Windows.Forms.Button();
            this.txt_kisiNoTcAdresBorcAdTutar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_vatandasRaporDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adresSorgu
            // 
            this.btn_adresSorgu.BackColor = System.Drawing.Color.Maroon;
            this.btn_adresSorgu.ForeColor = System.Drawing.Color.White;
            this.btn_adresSorgu.Location = new System.Drawing.Point(22, 12);
            this.btn_adresSorgu.Name = "btn_adresSorgu";
            this.btn_adresSorgu.Size = new System.Drawing.Size(357, 30);
            this.btn_adresSorgu.TabIndex = 0;
            this.btn_adresSorgu.Text = "Adres iline göre yapılan sorgu";
            this.btn_adresSorgu.UseVisualStyleBackColor = false;
            this.btn_adresSorgu.Click += new System.EventHandler(this.btn_adresSorgu_Click);
            // 
            // btn_meslekSorgu
            // 
            this.btn_meslekSorgu.BackColor = System.Drawing.Color.Maroon;
            this.btn_meslekSorgu.ForeColor = System.Drawing.Color.White;
            this.btn_meslekSorgu.Location = new System.Drawing.Point(22, 74);
            this.btn_meslekSorgu.Name = "btn_meslekSorgu";
            this.btn_meslekSorgu.Size = new System.Drawing.Size(357, 26);
            this.btn_meslekSorgu.TabIndex = 1;
            this.btn_meslekSorgu.Text = "Mesleğe göre yapılan sorgu";
            this.btn_meslekSorgu.UseVisualStyleBackColor = false;
            this.btn_meslekSorgu.Click += new System.EventHandler(this.btn_meslekSorgu_Click);
            // 
            // txt_sehirSorgu
            // 
            this.txt_sehirSorgu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_sehirSorgu.Location = new System.Drawing.Point(22, 48);
            this.txt_sehirSorgu.Name = "txt_sehirSorgu";
            this.txt_sehirSorgu.Size = new System.Drawing.Size(357, 20);
            this.txt_sehirSorgu.TabIndex = 2;
            this.txt_sehirSorgu.Text = "Lütfen şehir ismi giriniz....";
            // 
            // txt_meslekSorgu
            // 
            this.txt_meslekSorgu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_meslekSorgu.Location = new System.Drawing.Point(22, 106);
            this.txt_meslekSorgu.Name = "txt_meslekSorgu";
            this.txt_meslekSorgu.Size = new System.Drawing.Size(357, 20);
            this.txt_meslekSorgu.TabIndex = 3;
            this.txt_meslekSorgu.Text = "Lütfen mesleği giriniz....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_vatandasRaporDetay);
            this.groupBox1.Location = new System.Drawing.Point(636, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 426);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vatandaş Bilgisi";
            // 
            // dgw_vatandasRaporDetay
            // 
            this.dgw_vatandasRaporDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_vatandasRaporDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_vatandasRaporDetay.Location = new System.Drawing.Point(3, 16);
            this.dgw_vatandasRaporDetay.Name = "dgw_vatandasRaporDetay";
            this.dgw_vatandasRaporDetay.Size = new System.Drawing.Size(280, 407);
            this.dgw_vatandasRaporDetay.TabIndex = 0;
            // 
            // btn_tcBaslangiciDokuz
            // 
            this.btn_tcBaslangiciDokuz.BackColor = System.Drawing.Color.Maroon;
            this.btn_tcBaslangiciDokuz.ForeColor = System.Drawing.Color.White;
            this.btn_tcBaslangiciDokuz.Location = new System.Drawing.Point(22, 132);
            this.btn_tcBaslangiciDokuz.Name = "btn_tcBaslangiciDokuz";
            this.btn_tcBaslangiciDokuz.Size = new System.Drawing.Size(357, 26);
            this.btn_tcBaslangiciDokuz.TabIndex = 9;
            this.btn_tcBaslangiciDokuz.Text = "TC nosu 9 ile başlayıp 5 ile bitenler";
            this.btn_tcBaslangiciDokuz.UseVisualStyleBackColor = false;
            this.btn_tcBaslangiciDokuz.Click += new System.EventHandler(this.btn_tcBaslangiciDokuz_Click);
            // 
            // btn_meslekBorcDurumBakanlikAd
            // 
            this.btn_meslekBorcDurumBakanlikAd.BackColor = System.Drawing.Color.Maroon;
            this.btn_meslekBorcDurumBakanlikAd.ForeColor = System.Drawing.Color.White;
            this.btn_meslekBorcDurumBakanlikAd.Location = new System.Drawing.Point(22, 164);
            this.btn_meslekBorcDurumBakanlikAd.Name = "btn_meslekBorcDurumBakanlikAd";
            this.btn_meslekBorcDurumBakanlikAd.Size = new System.Drawing.Size(357, 26);
            this.btn_meslekBorcDurumBakanlikAd.TabIndex = 10;
            this.btn_meslekBorcDurumBakanlikAd.Text = "Meslek-Borç Durum-Bakanlık adı";
            this.btn_meslekBorcDurumBakanlikAd.UseVisualStyleBackColor = false;
            this.btn_meslekBorcDurumBakanlikAd.Click += new System.EventHandler(this.btn_meslekBorcDurumBakanlikAd_Click);
            // 
            // btn_kisiNoTcAdresBorcAdTutar
            // 
            this.btn_kisiNoTcAdresBorcAdTutar.BackColor = System.Drawing.Color.Maroon;
            this.btn_kisiNoTcAdresBorcAdTutar.ForeColor = System.Drawing.Color.White;
            this.btn_kisiNoTcAdresBorcAdTutar.Location = new System.Drawing.Point(22, 207);
            this.btn_kisiNoTcAdresBorcAdTutar.Name = "btn_kisiNoTcAdresBorcAdTutar";
            this.btn_kisiNoTcAdresBorcAdTutar.Size = new System.Drawing.Size(357, 26);
            this.btn_kisiNoTcAdresBorcAdTutar.TabIndex = 11;
            this.btn_kisiNoTcAdresBorcAdTutar.Text = "Kişi Nosuna göre  TC-adres-borç adı-borç tutarı";
            this.btn_kisiNoTcAdresBorcAdTutar.UseVisualStyleBackColor = false;
            this.btn_kisiNoTcAdresBorcAdTutar.Click += new System.EventHandler(this.btn_kisiNoTcAdresBorcAdTutar_Click);
            // 
            // txt_kisiNoTcAdresBorcAdTutar
            // 
            this.txt_kisiNoTcAdresBorcAdTutar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_kisiNoTcAdresBorcAdTutar.Location = new System.Drawing.Point(22, 239);
            this.txt_kisiNoTcAdresBorcAdTutar.Name = "txt_kisiNoTcAdresBorcAdTutar";
            this.txt_kisiNoTcAdresBorcAdTutar.Size = new System.Drawing.Size(357, 20);
            this.txt_kisiNoTcAdresBorcAdTutar.TabIndex = 12;
            this.txt_kisiNoTcAdresBorcAdTutar.Text = "Kişi no giriniz...";
            // 
            // VatandasRaporDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.txt_kisiNoTcAdresBorcAdTutar);
            this.Controls.Add(this.btn_kisiNoTcAdresBorcAdTutar);
            this.Controls.Add(this.btn_meslekBorcDurumBakanlikAd);
            this.Controls.Add(this.btn_tcBaslangiciDokuz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_meslekSorgu);
            this.Controls.Add(this.txt_sehirSorgu);
            this.Controls.Add(this.btn_meslekSorgu);
            this.Controls.Add(this.btn_adresSorgu);
            this.Name = "VatandasRaporDetay";
            this.Text = "Vatandaş Rapor Detayı";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_vatandasRaporDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adresSorgu;
        private System.Windows.Forms.Button btn_meslekSorgu;
        private System.Windows.Forms.TextBox txt_sehirSorgu;
        private System.Windows.Forms.TextBox txt_meslekSorgu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_vatandasRaporDetay;
        private System.Windows.Forms.Button btn_tcBaslangiciDokuz;
        private System.Windows.Forms.Button btn_meslekBorcDurumBakanlikAd;
        private System.Windows.Forms.Button btn_kisiNoTcAdresBorcAdTutar;
        private System.Windows.Forms.TextBox txt_kisiNoTcAdresBorcAdTutar;
    }
}